#!/usr/bin/python3

import pyrob.solutions.all_tasks
import pyrob
import pyrob.core
import pyrob.viz

import pyscreenshot as ImageGrab

tasks = [t.__name__ for t in pyrob.tasks_to_run]

pyrob.utils.allow_internal(True, False)

for task_id in tasks:

    pyrob.core.on_position_changed = None

    cls = pyrob.get_task_class(task_id)
    task_inst = cls()
    task_inst.load_level(0)

    pyrob.core.on_position_changed = pyrob.viz.update_robot_position(0.1)

    pyrob.viz.init()
    pyrob.viz.render_maze(task_id)

    pyrob.core.on_position_changed(*pyrob.core.get_pos())

    x = pyrob.viz.canvas.winfo_rootx()
    y = pyrob.viz.canvas.winfo_rooty()

    w = pyrob.viz.canvas.winfo_width()
    h = pyrob.viz.canvas.winfo_height()

    ImageGrab.grab(bbox=(x, y, x + w, y + h)).save('/tmp/{}.png'.format(task_id))



