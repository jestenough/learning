#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled


class Task:
    CHECKS = 5

    def load_level(self, n):

        m = 1 + 2*(n+2)

        rob.set_field_size(m, m)


        for i in range(m):
            for j in range(m):
                if i != j and i != m-1-j:
                    rob.set_cell_type(i, j, rob.CELL_TO_BE_FILLED)

        self.cells_to_be_filled = find_cells_to_be_filled()

        rob.set_parking_cell(m-1, 0)

        rob.goto(0, 0)

    def check_solution(self):

        return check_filled_cells(self.cells_to_be_filled) and rob.is_parking_point()
