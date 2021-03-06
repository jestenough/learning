#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 4

    def load_level(self, n):
        rob.set_field_size(10, 10)

        cases = {
            0: ((0, 0), (9, 9)),
            1: ((0, 9), (9, 0)),
            2: ((9, 0), (0, 9)),
            3: ((9, 9), (0, 0)),
        }

        pos, cpos = cases[n]

        rob.set_parking_cell(*cpos)

        rob.goto(*pos)


    def check_solution(self):

        return rob.is_parking_point()
