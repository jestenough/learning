#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.03)
def task_9_3():

    def square_side_length():
        x = 1
        while not wall_is_on_the_right():
            x += 1
            move_right()
        else:
            move_left(x - 1)
            return x
    def fill_row(i, l):
        column = 1
        while column <= l:
            if column != i and column != (l + 1 - i):
                fill_cell()
            if wall_is_on_the_right() == False:
                move_right()
            column += 1
        else:
            move_left(l-1)

    l = square_side_length()
    for i in range(1, l + 1):
        fill_row(i,l)
        if not wall_is_beneath():
            move_down()
        

if __name__ == '__main__':
    run_tasks()
