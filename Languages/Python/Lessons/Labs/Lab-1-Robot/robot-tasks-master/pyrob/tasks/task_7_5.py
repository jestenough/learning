#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled
import random

class Task:
    CHECKS = 5

    def load_level(self, n):

        m = random.randint(20, 40)

        rob.set_field_size(3, m)

        rob.goto(1, 1)

        d = 0
        _d = 0

        while not rob.wall_is_on_the_right():
            if _d == 0:
                pos = rob.get_pos()
                rob.set_cell_type(pos[0], pos[1], rob.CELL_TO_BE_FILLED)
                d += 1
                _d = d
            rob.move_right()
            _d -= 1

        self.cells_to_fill = find_cells_to_be_filled()

        rob.set_parking_cell(1, m-1)

        rob.goto(1, 0)

    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point()
