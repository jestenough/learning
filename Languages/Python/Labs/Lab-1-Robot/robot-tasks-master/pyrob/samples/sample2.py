#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.1)
def example2():

    while not wall_is_on_the_right():
        move_right()

    while not wall_is_beneath():
        move_down()

run_tasks(verbose=True)
