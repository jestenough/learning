#!/usr/bin/python3

import functools
import importlib
import logging

from pyrob import core
from pyrob import utils

tasks_to_run = []

logger = logging.getLogger(__name__)


def get_task_class(task_id):
    module = importlib.import_module('pyrob.tasks.' + task_id)
    return module.Task


def task(*args, **kwargs):

    def decorator(f):

        @functools.wraps(f)
        def wrapper():
            task_id = f.__name__
            clazz = get_task_class(task_id)
            passed = True
            for i in range(clazz.CHECKS):
                core.on_position_changed = None

                _task = clazz()
                with utils.allow_internal(True):
                    _task.load_level(i)

                core.on_position_changed = viz.update_robot_position(delay)
                core.on_cell_type_changed = viz.update_cell_color

                with utils.allow_internal(True):
                    viz.render_maze(task_id)
                    core.on_position_changed(*core.get_pos())

                crashed = False
                error = False
                try:
                    f()
                except Exception as e:
                    logger.exception('Caught exception')
                    passed = False
                    error = True
                    if isinstance(e, core.RobotCrashed):
                        crashed = True

                with utils.allow_internal(True):
                    passed = passed and _task.check_solution()

                if passed:
                    logger.debug('Test #{} passed for task {}'.format(i + 1, task_id))
                    viz.on_task_completed(True)
                else:
                    logger.error('Test #{} failed for task {}'.format(i+1, task_id))
                    if crashed:
                        viz.on_robot_crashed()
                    elif error:
                        viz.on_task_errored()
                    else:
                        viz.on_task_completed(False)

                    break

            return passed

        tasks_to_run.append(wrapper)
        return wrapper

    if 'delay' in kwargs:
        delay = kwargs['delay']
        return decorator
    else:
        delay = None
        return decorator(args[0])


def run_tasks(verbose=False, headless=False):

    logging.basicConfig(level=(logging.DEBUG if verbose else logging.INFO))

    global viz
    viz = importlib.import_module('pyrob.dummy_viz' if headless else 'pyrob.viz')

    viz.init()

    passed = 0
    for t in tasks_to_run:
        logger.info('Starting task {}'.format(t.__name__))
        status = t()
        if status:
            passed += 1
        logger.info('Task {} finished: {}'.format(t.__name__, ('+' if status else '-')))

    logger.info('Total: {}/{}'.format(passed, len(tasks_to_run)))

    return passed == len(tasks_to_run)