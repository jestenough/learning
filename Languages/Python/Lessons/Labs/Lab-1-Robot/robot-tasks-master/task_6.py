#!/usr/bin/python3

from pyrob.api import *


@task
def task_5_3():

    while not wall_is_beneath():
        move_right()

    while wall_is_beneath():
        move_right()


if __name__ == '__main__':
    run_tasks()
