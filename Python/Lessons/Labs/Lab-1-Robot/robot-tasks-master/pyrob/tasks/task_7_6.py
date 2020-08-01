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

        for k, i in enumerate(cells):
            rob.goto(1, i)
            rob.fill_cell()

            if k == 4:
                rob.set_parking_cell(*rob.get_pos())

        rob.goto(1, 0)

    def check_solution(self):

        return rob.is_parking_point()
