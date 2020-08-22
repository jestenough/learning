#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 3

    def load_level(self, n):
        self.m = random.randint(5, 10)
        self.n = random.randint(5, 10)

        rob.set_field_size(self.m, self.n)
        rob.goto(0, 0)

    def check_solution(self):
        return rob.get_pos() == (self.m-1, self.n-1)
