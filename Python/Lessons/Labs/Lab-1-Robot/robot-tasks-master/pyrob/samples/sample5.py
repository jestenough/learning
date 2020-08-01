#!/usr/bin/python3

from pyrob.api import *


@task
def example3():

    for i in range(9):
        fill_cell()
        move_right()
        move_down()

    fill_cell()

run_tasks(verbose=True)
