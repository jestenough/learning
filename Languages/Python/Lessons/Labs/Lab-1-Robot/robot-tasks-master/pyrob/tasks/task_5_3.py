#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(10, 20)

        j = random.randint(2, 6)
        l = random.randint(5, 10)
        i = random.randint(2, 8)

        rob.goto(i, j)
        for k in range(j, j+l+1):
            rob.put_wall(bottom=True)
            rob.move_right()

        rob.set_parking_cell(*rob.get_pos())

        rob.goto(i, 1)


    def check_solution(self):

        return rob.is_parking_point()
