#!/usr/bin/python3

from pyrob.api import *


@task
def task_5_4():

    while not wall_is_beneath():
        move_down()

    while wall_is_beneath():
        move_right()

    move_down()

    while not wall_is_on_the_left():
        move_left()

if __name__ == '__main__':
    run_tasks()
