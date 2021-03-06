#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.001)
def task_7_5():
    n = -1
    while not wall_is_on_the_right():
        move_right()
        fill_cell()
        n+=1
        for i in range(n):
            if not wall_is_on_the_right():
                move_right()

if __name__ == '__main__':
    run_tasks()
