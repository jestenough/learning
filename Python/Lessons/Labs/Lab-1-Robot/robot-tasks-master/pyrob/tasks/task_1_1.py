#!/usr/bin/python3

import pyrob.core as rob


class Task:
    CHECKS = 1

    def load_level(self, n):
        rob.set_field_size(10, 10)
        rob.set_parking_cell(1, 2)
        rob.goto(0, 0)

    def check_solution(self):
        return rob.is_parking_point()