#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(15, 15)

        l = random.randint(5, 13)
        i = random.randint(2, 8)

        rob.goto(i, 0)
        for k in range(l):
            rob.put_wall(bottom=True)
            rob.move_right()

        rob.set_parking_cell(i+1, 0)

        rob.goto(0, 0)


    def check_solution(self):

        return rob.is_parking_point()
