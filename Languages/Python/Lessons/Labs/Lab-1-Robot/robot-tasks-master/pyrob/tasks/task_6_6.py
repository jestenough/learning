#!/usr/bin/python3

import pyrob.core as rob
from pyrob.tasks import check_filled_cells, find_cells_to_be_filled
import random


class Task:
    CHECKS = 5

    def load_level(self, n):
        rob.set_field_size(13, 20)

        l = random.randint(10, 15)

        corridors = [random.randint(0, 1) for i in range(l)]

        rob.goto(10, 1)
        for i in range(l):
            rob.move_right()
            rob.put_wall(bottom=True)

            if not corridors[i]:
                rob.put_wall(top=True)
                continue

            k = random.randint(1, 8)
            for j in range(k):
                rob.move_up()
                pos = rob.get_pos()
                rob.set_cell_type(pos[0], pos[1], rob.CELL_TO_BE_FILLED)
                rob.put_wall(left=True, right=True)

            rob.put_wall(top=True)

            for j in range(k):
                rob.move_down()

        self.cells_to_fill = find_cells_to_be_filled()

        rob.put_wall(right=True)
        rob.set_parking_cell(10, 1)

        rob.goto(10, 1)


    def check_solution(self):

        return check_filled_cells(self.cells_to_fill) and rob.is_parking_point()
