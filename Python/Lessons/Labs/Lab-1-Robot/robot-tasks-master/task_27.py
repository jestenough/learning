#!/usr/bin/python3

from pyrob.api import *


@task
def task_7_5():
    n = -1
    while not wall_is_on_the_right():
        move_right()
        n+=1
        fill_cell()
        for i in range(n):
            if not wall_is_on_the_right():
                move_right()


if __name__ == '__main__':
    run_tasks()
