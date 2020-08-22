#!/usr/bin/python3

from pyrob.api import *


@task
def task_8_21():

    while True:
        if wall_is_above() and wall_is_on_the_left():
            for i in range(9):
                move_right()
                move_down()
        elif wall_is_above() and wall_is_on_the_right():
            for i in range(9):
                move_left()
                move_down()
        elif wall_is_beneath() and wall_is_on_the_right():
            for i in range(9):
                move_up()
                move_left()
        elif wall_is_beneath() and wall_is_on_the_left():
            for i in range(9):
                move_up()
                move_right()
        break

if __name__ == '__main__':
    run_tasks()
