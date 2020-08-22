#!/usr/bin/python3

import pyrob.core as rob
import random


class Task:
    CHECKS = 10

    def load_level(self, n):
        rob.set_field_size(11, 11)

        a = random.randint(1, 7)
        b = random.randint(1, 3)
        c = 1 if random.randint(0, 1) else -1

        rob.goto(10, 5)

        for i in range(a):
            rob.put_wall(left=True, right=True)
            rob.move_up()

        if c == 1:
            rob.put_wall(left=True, top=True)
        else:
            rob.put_wall(right=True, top=True)

        for i in range(b):
            if c == 1:
                rob.move_right()
            else:
                rob.move_left()
            rob.put_wall(top=True, bottom=True)

        if c == -1:
            rob.put_wall(left=True)
        else:
            rob.put_wall(right=True)

        rob.set_parking_cell(*rob.get_pos())

        rob.goto(10, 5)


    def check_solution(self):

        return rob.is_parking_point()
