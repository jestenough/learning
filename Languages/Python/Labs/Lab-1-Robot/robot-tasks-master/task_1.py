#!/usr/bin/python3

from pyrob.api import *


@task
def task_1_1():
    for i in range(2):
        move_right()
        if i == 1:
            move_down()

if __name__ == '__main__':
    run_tasks()
