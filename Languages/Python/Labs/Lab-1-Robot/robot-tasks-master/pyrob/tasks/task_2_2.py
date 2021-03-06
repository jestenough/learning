#!/usr/bin/python3

import pyrob.core as rob
from . import check_filled_cells, find_cells_to_be_filled


class Task:
    CHECKS = 1

    def load_level(self, n):
        rob.set_field_size(9, 19)

        rob.set_parking_cell(1, 16)

        for i in range(5):
            rob.set_cell_type(2, 1 + 4*i, rob.CELL_TO_BE_FILLED)
            rob.set_cell_type(2, 2 + 4*i, rob.CELL_TO_BE_FILLED)
            rob.set_cell_type(2, 0 + 4*i, rob.CELL_TO_BE_FILLED)
            rob.set_cell_type(3, 1 + 4*i, rob.CELL_TO_BE_FILLED)
            rob.set_cell_type(1, 1 + 4*i, rob.CELL_TO_BE_FILLED)

        self.cells_to_be_filled = find_cells_to_be_filled()

        rob.goto(0, 0)

    def check_solution(self):
        if not rob.is_parking_point():
            return False

        return check_filled_cells(self.cells_to_be_filled)