#!/usr/bin/python3

from pyrob.api import *


def fill():
    fill_cell()
    move_right()
    fill_cell()
    move_left(2)
    fill_cell()
    move_right()
    move_up()
    fill_cell()
    move_down(2)
    fill_cell()
    move_up()

@task
def task_2_1():
    move_right(2)
    move_down(2)
    fill()
    move_up()
    move_left()
    
if __name__ == '__main__':
    run_tasks()
