#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 3

    def load_level(self, n):
        rob.set_field_size(11, 11)

        i = random.randint(4, 8)

        rob.goto(i, 1)
        if n != 1:
            rob.put_wall(left=True)

        for k in range(1, 10):
            rob.put_wall(bottom=True, top=True)
            rob.move_right()

        if n != 0:
            rob.put_wall(left=True)

        if n != 2:
            rob.set_parking_cell(0, 0)
        else:
            rob.set_parking_cell(i, 9)

        rob.goto(i, 5)


    def check_solution(self):

        return rob.is_parking_point()
