#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells
import random

class Task:
    CHECKS = 5

    def load_level(self, n):

        m = random.randint(20, 40)

        rob.set_field_size(3, m)

        cells = list(range(1, m))
        random.shuffle(cells)
        cells = sorted(cells[:random.randint(7, m-5)])

        for i in cells:
            rob.set_cell_type(1, i, rob.CELL_FILLED)

        rob.goto(1, 0)

        c = 0
        while not rob.wall_is_on_the_right():
            if rob.cell_is_filled():
                c += 1
                if c == 3:
                    break
            else:
                c = 0
            rob.move_right()

        rob.set_parking_cell(*rob.get_pos())

        rob.goto(1, 0)

    def check_solution(self):

        return rob.is_parking_point()
