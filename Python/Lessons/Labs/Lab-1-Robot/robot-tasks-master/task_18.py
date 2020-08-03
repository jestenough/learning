#!/usr/bin/python3

from pyrob.api import *


@task
def task_8_28():

    while not wall_is_on_the_left(): 
        move_left()
    while not wall_is_on_the_right():
        if not wall_is_above():
            while wall_is_beneath():
                move_up()
            else:
                break
        else:
            move_right()
    while not wall_is_above():
        move_up()
    while not wall_is_on_the_left():
        move_left()
           
if __name__ == '__main__':
    run_tasks()
