#!/usr/bin/python3

import pyrob.core as rob
from . import check_filled_cells


class Task:
    CHECKS = 1

    def load_level(self, n):
        rob.set_field_size(10, 10)

        rob.set_parking_cell(3, 4)
        rob.set_cell_type(2, 2, rob.CELL_TO_BE_FILLED)

        rob.goto(0, 0)

    def check_solution(self):
        if not rob.is_parking_point():
            return False

        return check_filled_cells([(2, 2)])