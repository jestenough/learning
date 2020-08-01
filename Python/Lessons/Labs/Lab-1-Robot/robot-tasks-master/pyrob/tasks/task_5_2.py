#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(10, 10)

        i = random.randint(2, 8)
        l = random.randint(1, 8)

        rob.goto(i, 1)
        for k in range(l):
            rob.put_wall(bottom=True)
            rob.move_right()

        rob.set_parking_cell(*rob.get_pos())

        rob.goto(i, 1)


    def check_solution(self):

        return rob.is_parking_point()
