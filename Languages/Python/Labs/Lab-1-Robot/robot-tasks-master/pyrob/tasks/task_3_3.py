#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 4

    def load_level(self, n):
        rob.set_field_size(10, 10)

        walls = [
            ({'left': True, 'right': True, 'top': True}, (1, 0)),
            ({'left': True, 'right': True, 'bottom': True}, (-1, 0)),
            ({'top': True, 'bottom': True, 'left': True}, (0, 1)),
            ({'top': True, 'bottom': True, 'right': True}, (0, -1))
        ]

        rob.goto(2, 2)
        args, (di, dj) = walls[n]
        rob.put_wall(**args)

        rob.set_parking_cell(2 + di, 2 + dj)


    def check_solution(self):

        return rob.is_parking_point()
