#!/usr/bin/python3

from pyrob.api import *


@task
def example1():

    for i in range(5):
        move_down()
        move_right()

    raise NotImplementedError()


run_tasks(verbose=True)
