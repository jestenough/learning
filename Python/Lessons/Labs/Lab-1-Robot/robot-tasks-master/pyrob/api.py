#!/usr/bin/python3

from pyrob.core import move_left, move_right, move_up, move_down
from pyrob.core import wall_is_above, wall_is_beneath, wall_is_on_the_left, wall_is_on_the_right
from pyrob.core import fill_cell, cell_is_filled
from pyrob.core import mov
from pyrob import task
from pyrob import run_tasks
