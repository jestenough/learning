#!/usr/bin/python3

from pyrob.api import *


@task(delay=0.05)
def task_4_11():
    pass


if __name__ == '__main__':
    run_tasks()
