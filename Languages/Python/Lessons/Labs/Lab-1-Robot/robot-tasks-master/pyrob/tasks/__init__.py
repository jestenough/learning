#!/usr/bin/python3


import pyrob.core as rob


def check_filled_cells(expected):
    cells = set(expected)

    m, n = rob.get_field_size()

    for i in range(m):
        for j in range(n):
            if rob.get_cell_type(i, j) == rob.CELL_FILLED:
                if (i, j) not in cells:
                    return False
                else:
                    cells.remove((i, j))
            else:
                if (i, j) in cells:
                    return False

    return len(cells) == 0


def find_cells_to_be_filled():
    cells = []

    m, n = rob.get_field_size()
    for i in range(m):
        for j in range(n):
            if rob.get_cell_type(i, j) == rob.CELL_TO_BE_FILLED:
                cells.append((i, j))

    return cells


def find_filled_cells():
    cells = []

    m, n = rob.get_field_size()
    for i in range(m):
        for j in range(n):
            if rob.get_cell_type(i, j) == rob.CELL_FILLED:
                cells.append((i, j))

    return cells