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
def task_2_2():
        move_right()
        move_down(2)
        for i in range(5):
            fill()
            if i == 4:
                move_up()
                move_left()
                break
            move_right(4)

if __name__ == '__main__':
    run_tasks()
