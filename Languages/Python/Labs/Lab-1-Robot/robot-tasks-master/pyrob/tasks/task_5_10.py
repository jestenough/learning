#!/usr/bin/python3

import pyrob.core as rob
import random
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled


class Task:
    CHECKS = 5

    def load_level(self, n):
        if n != self.CHECKS-1:
            m = random.randint(5, 10)
            n = random.randint(5, 10)
        else:
            m = 1
            n = 1

        rob.set_field_size(m, n)

        for i in range(m):
            for j in range(n):
                rob.set_cell_type(i, j, rob.CELL_TO_BE_FILLED)

        self.cells_to_fill = find_cells_to_be_filled()

        rob.set_parking_cell(m-1, 0)

        rob.goto(0, 0)

    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point()