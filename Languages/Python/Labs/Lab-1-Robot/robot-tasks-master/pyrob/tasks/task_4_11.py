#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled


class Task:
    CHECKS = 1

    def load_level(self, n):
        rob.set_field_size(15, 15)

        for i in range(1, 14):
            for j in range(1, 1+i):
                rob.set_cell_type(i, j, rob.CELL_TO_BE_FILLED)

        self.cells_to_fill = find_cells_to_be_filled()

        rob.set_parking_cell(14, 1)

        rob.goto(0, 0)


    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point()
