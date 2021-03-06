#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(11, 11)

        i = random.randint(3, 8)
        dj = 1 if random.randint(0, 1) == 0 else -1

        rob.set_cell_type(i, 5, rob.CELL_FILLED)
        rob.set_cell_type(i, 5+dj, rob.CELL_FILLED)

        rob.set_parking_cell(i, 5+dj)

        rob.goto(10, 5)


    def check_solution(self):

        return rob.is_parking_point()
