#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(10, 20)

        l = random.randint(5, 12)
        i = random.randint(2, 6)
        j = random.randint(0, 5)

        rob.goto(i, j)
        for m in range(l):
            k = random.randint(0, 1)
            rob.put_wall(bottom=(k == 0), top=(k == 1))
            rob.move_right()

        rob.set_parking_cell(*rob.get_pos())

        rob.goto(i, j)


    def check_solution(self):

        return rob.is_parking_point()
