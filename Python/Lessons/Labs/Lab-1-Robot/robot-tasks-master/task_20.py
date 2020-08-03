#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.05)
def task_4_3():

    for i in range(12):
        for j in range(27):
            move_right()
            fill_cell()
        move_down()
        while not wall_is_on_the_left():
            move_left()
    move_right()

if __name__ == '__main__':
    run_tasks()
