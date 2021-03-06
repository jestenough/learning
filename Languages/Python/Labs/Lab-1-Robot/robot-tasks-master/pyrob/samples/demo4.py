#!/usr/bin/python3

from pyrob.api import *


@task
def example1():

    for i in range(10):
        move_right()
        move_down()

if __name__ == '__main__':
    run_tasks()
