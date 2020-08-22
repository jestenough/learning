#!/usr/bin/python3

from pyrob.api import *


@task
def task_1_2():
    for i in range(2):
        move_down(1)
        if i == 1:
            fill_cell()
        move_right(2)
    move_down()




if __name__ == '__main__':
    run_tasks()
