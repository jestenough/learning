#!/usr/bin/python3

from pyrob.api import *


@task
def example1():

    move_up()


@task
def example2():

    move_down()


run_tasks(verbose=True)
