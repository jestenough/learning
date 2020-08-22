#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled
import random


class Task:
    CHECKS = 5

    def load_level(self, n):
        n = random.randint(20, 30)

        rob.set_field_size(3, n)

        cases = {
            0: {'top': True},
            1: {'bottom': True},
            2: {'top': True, 'bottom': True},
            3: {}
        }

        rob.goto(1, 0)
        for j in range(n):
            case = random.randint(0, 3)
            rob.put_wall(**cases[case])
            if case != 3:
                rob.set_cell_type(1, j, rob.CELL_TO_BE_FILLED)

            if j != n-1:
                rob.move_right()

        self.cells_to_fill = find_cells_to_be_filled()

        rob.set_parking_cell(1, n-1)

        rob.goto(1, 0)

    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point()
