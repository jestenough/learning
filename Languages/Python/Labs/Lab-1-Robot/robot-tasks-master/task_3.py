#!/usr/bin/python3

from pyrob.api import *


@task
def task_3_1():
    while not wall_is_on_the_right():
        move_right()


if __name__ == '__main__':
    run_tasks()
