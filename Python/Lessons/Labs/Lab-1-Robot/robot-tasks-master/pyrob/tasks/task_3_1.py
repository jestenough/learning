#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 5

    def load_level(self, n):
        rob.set_field_size(10, 10)

        j = random.randint(2, 8)
        rob.goto(2, j)
        rob.put_wall(right=True)

        rob.set_parking_cell(2, j)

        rob.goto(2, 0)

    def check_solution(self):

        return rob.is_parking_point()
