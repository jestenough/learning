#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.01)
def task_6_6():
    while not wall_is_on_the_right():
        move_right()
        if not wall_is_above():
            while not wall_is_above():
                move_up()
                fill_cell()
            while not wall_is_beneath():
                move_down()
    else:
        while wall_is_above() or wall_is_beneath():
            move_left()



if __name__ == '__main__':
    run_tasks()
