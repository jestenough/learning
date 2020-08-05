#!/usr/bin/python3

from pyrob.api import *


def walk_up():
    n = 0
    while not wall_is_above():
        move_up()
        if cell_is_filled():
            n += 1
        else:
            fill_cell()
    
    while not wall_is_beneath():
        move_down()
    
    return n        


@task(delay=0.01)
def task_8_18():
    n = 0
    while not wall_is_on_the_right():
        if cell_is_filled():
            n += 1
        if wall_is_above() and wall_is_beneath():
            if not cell_is_filled():
                fill_cell()
        else:
            n += walk_up()
        move_right()
    
    mov('ax', n)


if __name__ == '__main__':
    run_tasks()
