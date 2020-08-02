#!/usr/bin/python3

from pyrob.api import *


@task
def task_8_2():
    while not wall_is_on_the_right():
        if not wall_is_above():
            fill_cell()
        move_right()
        if not wall_is_above():
            fill_cell()
            
if __name__ == '__main__':
    run_tasks()
