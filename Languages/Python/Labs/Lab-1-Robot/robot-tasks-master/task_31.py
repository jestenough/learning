#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.001)
def task_8_30():
    
    flag = 0
    while flag < 2:
        while not wall_is_on_the_left():
            move_left()
            while not wall_is_beneath():
                move_down()
                flag = 0
        else:
            flag += 1

        while not wall_is_on_the_right():
            move_right()
            while not wall_is_beneath():
                move_down()
                flag = 0
        else:
            flag += 1

        if flag == 2:
            while not wall_is_on_the_left():
                move_left()
        else:
            flag = 0

if __name__ == '__main__':
    run_tasks()
