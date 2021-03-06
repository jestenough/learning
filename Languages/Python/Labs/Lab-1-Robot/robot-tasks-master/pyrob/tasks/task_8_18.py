#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled, find_filled_cells
import random


class Task:
    CHECKS = 5

    def load_level(self, n):
        l = random.randint(20, 30)
        rob.set_field_size(13, l+1)

        corridors = [random.randint(0, 1) for i in range(l)]

        self.filled_cells_number = 0

        rob.goto(10, 0)
        rob.put_wall(top=True, bottom=True)
        rob.set_cell_type(10, 0, rob.CELL_TO_BE_FILLED)
        for j in range(l-1):
            rob.move_right()
            rob.put_wall(bottom=True)

            if not corridors[j+1]:
                rob.put_wall(top=True)
                rob.set_cell_type(10, j+1, rob.CELL_TO_BE_FILLED)
                continue

            k = random.randint(1, 8)
            for q in range(k):
                rob.move_up()
                pos = rob.get_pos()
                if random.randint(0, 1) == 0:
                    rob.fill_cell()
                    self.filled_cells_number += 1
                else:
                    rob.set_cell_type(pos[0], pos[1], rob.CELL_TO_BE_FILLED)
                rob.put_wall(left=True, right=True)

            rob.put_wall(top=True)

            for q in range(k):
                rob.move_down()

        self.cells_to_fill = find_cells_to_be_filled() + find_filled_cells()

        rob.set_parking_cell(10, l)

        rob.goto(10, 0)

    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point() and rob.get_register_value('ax') == self.filled_cells_number
