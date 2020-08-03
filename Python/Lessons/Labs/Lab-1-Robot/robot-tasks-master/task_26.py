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

def back():
    for i in range(9):
        fill()
        move_right(4)
    fill()
    while not wall_is_on_the_left():
        move_left()
    move_right()


@task(delay=0.03)
def task_2_4():
    move_right()
    move_down()
    fill()
    back()
    for i in range(4):
        fill()
        move_down(4)
        back()
    move_up()
    move_left()




if __name__ == '__main__':
    run_tasks()
