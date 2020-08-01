#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):

        m = random.randint(15, 20)
        n = random.randint(15, 20)

        rob.set_field_size(m ,n)

        for i in range(m-1):
            if random.randint(0, 1) == 0:
                continue

            rob.goto(i, 0)

            k = random.randint(1, n-2)
            for j in range(n):
                if j != k:
                    rob.put_wall(bottom=True)
                if j != n-1:
                    rob.move_right()

        rob.set_parking_cell(m-1, 0)

        rob.goto(0, n-1)


    def check_solution(self):

        return rob.is_parking_point()
