#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(11, 11)

        i = random.randint(4, 8)
        j = random.randint(1, 9)
        q = random.randint(1, 9)

        rob.goto(i, 1)
        rob.put_wall(left=True)

        for k in range(1, 10):
            rob.put_wall(bottom=True)
            if k != j:
                rob.put_wall(top=True)
            rob.move_right()

        rob.put_wall(left=True)

        rob.set_parking_cell(0, 0)

        rob.goto(i, q)


    def check_solution(self):

        return rob.is_parking_point()
