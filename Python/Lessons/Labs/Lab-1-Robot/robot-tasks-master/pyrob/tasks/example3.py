#!/usr/bin/python3

import pyrob.core as rob


class Task:
    CHECKS = 1

    def load_level(self, n):
        rob.set_field_size(10, 10)

        for i in range(10):
            rob.set_cell_type(i, i, rob.CELL_TO_BE_FILLED)

        rob.set_parking_cell(3, 3)
        rob.set_parking_cell(9, 9)

        rob.goto(2, 4)
        for i in range(4):
            rob.put_wall(top=True, bottom=True)
            rob.move_right()

        rob.goto(0, 0)

    def check_solution(self):
        if not rob.is_parking_point():
            return False

        cell_status = {
            True: rob.CELL_FILLED,
            False: rob.CELL_EMPTY
        }

        for i in range(10):
            for j in range(10):
                if rob.get_cell_type(i, j) != cell_status[i == j]:
                    return False

        return True