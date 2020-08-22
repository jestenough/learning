#!/usr/bin/python3

from pyrob.utils import log_invocation, internal, public, repeat

import logging

WALL_LEFT = 1 << 0
WALL_RIGHT = 1 << 1
WALL_TOP = 1 << 2
WALL_BOTTOM = 1 << 3

CELL_EMPTY = 0
CELL_TO_BE_FILLED = 1
CELL_FILLED = 2

logger = logging.getLogger(__name__)

on_position_changed = None
on_cell_type_changed = None


class FieldCell:
    def __init__(self, i, j):
        self.i = i
        self.j = j
        self.type = CELL_EMPTY
        self.walls_flag = 0
        self.parking_cell = False


class RobotCrashed(Exception):
    pass


@log_invocation
@internal
def set_field_size(m, n):
    assert m > 0
    assert n > 0

    global registers
    registers = {}

    global max_i, max_j, field

    max_i = m-1
    max_j = n-1

    field = [[FieldCell(i, j) for j in range(n)] for i in range(m)]

    goto(0, 0)
    for i in range(n-1):
        put_wall(top=True)
        move_right()

    put_wall(top=True)

    for i in range(m-1):
        put_wall(right=True)
        move_down()

    put_wall(right=True)

    for i in range(n-1):
        put_wall(bottom=True)
        move_left()

    put_wall(bottom=True)

    for i in range(m-1):
        put_wall(left=True)
        move_up()

    put_wall(left=True)


@log_invocation
@internal
def get_field_size():
    global max_i, max_j, field
    assert max_i >= 0
    assert max_j >= 0

    return max_i+1, max_j+1


@log_invocation
@internal
def put_wall(left=False, right=False, top=False, bottom=False):
    global field, cur_i, cur_j

    assert field
    assert 0 <= cur_i <= max_i
    assert 0 <= cur_j <= max_j

    walls = []

    if left:
        flag, nflag = WALL_LEFT, WALL_RIGHT
        nj, ni = cur_j-1, cur_i
        walls.append((flag, nflag, ni, nj))

    if right:
        flag, nflag = WALL_RIGHT, WALL_LEFT
        nj, ni = cur_j+1, cur_i
        walls.append((flag, nflag, ni, nj))

    if top:
        flag, nflag = WALL_TOP, WALL_BOTTOM
        nj, ni = cur_j, cur_i-1
        walls.append((flag, nflag, ni, nj))

    if bottom:
        flag, nflag = WALL_BOTTOM, WALL_TOP
        nj, ni = cur_j, cur_i+1
        walls.append((flag, nflag, ni, nj))

    for flag, nflag, ni, nj in walls:
        field[cur_i][cur_j].walls_flag |= flag

        if 0 <= ni <= max_i and 0 <= nj <= max_j:
            field[ni][nj].walls_flag |= nflag


@log_invocation
@internal
def is_blocked(i=None, j=None, flag=None):
    global max_i, max_j
    assert i is None or 0 <= i <= max_i
    assert j is None or 0 <= j <= max_j
    assert flag in [WALL_LEFT, WALL_RIGHT, WALL_TOP, WALL_BOTTOM]
    assert field

    _i = cur_i if i is None else i
    _j = cur_j if j is None else j
    logger.debug('Field value at ({}, {}) is {}'.format(_i, _j, field[_i][_j].walls_flag))
    return (field[_i][_j].walls_flag & flag) > 0


@log_invocation
@public
def wall_is_above():
    return is_blocked(None, None, WALL_TOP)


@log_invocation
@public
def wall_is_beneath():
    return is_blocked(None, None, WALL_BOTTOM)


@log_invocation
@public
def wall_is_on_the_left():
    return is_blocked(None, None, WALL_LEFT)


@log_invocation
@public
def wall_is_on_the_right():
    return is_blocked(None, None, WALL_RIGHT)

@log_invocation
@internal
def goto(i=None, j=None):
    global cur_i, cur_j

    assert i is None or 0 <= i <= max_i
    assert j is None or 0 <= j <= max_j

    if i is not None:
        cur_i = i
    if j is not None:
        cur_j = j

    global on_position_changed
    if on_position_changed:
        on_position_changed(cur_i, cur_j)


@log_invocation
@internal
def get_pos():
    return cur_i, cur_j


@log_invocation
@internal
def step_left():
    if is_blocked(flag=WALL_LEFT):
        raise RobotCrashed()

    goto(j=cur_j - 1)


@log_invocation
@internal
def step_right():
    if is_blocked(flag=WALL_RIGHT):
        raise RobotCrashed()

    goto(j=cur_j + 1)


@log_invocation
@internal
def step_up():
    if is_blocked(flag=WALL_TOP):
        raise RobotCrashed()

    goto(i=cur_i - 1)


@log_invocation
@internal
def step_down():
    if is_blocked(flag=WALL_BOTTOM):
        raise RobotCrashed()

    goto(i=cur_i + 1)


@log_invocation
@public
def move_left(n=1):
    repeat(n, step_left)


@log_invocation
@public
def move_right(n=1):
    repeat(n, step_right)


@log_invocation
@public
def move_up(n=1):
    repeat(n, step_up)


@log_invocation
@public
def move_down(n=1):
    repeat(n, step_down)


@log_invocation
@internal
def set_cell_type(i, j, type):
    assert 0 <= i <= max_i
    assert 0 <= j <= max_j
    assert type in [CELL_EMPTY, CELL_FILLED, CELL_TO_BE_FILLED]

    global field
    field[i][j].type = type


@log_invocation
@internal
def get_cell_type(i, j):
    assert 0 <= i <= max_i
    assert 0 <= j <= max_j

    global field
    return field[i][j].type


@log_invocation
@public
def fill_cell():
    global field, cur_i, cur_j

    assert field
    assert 0 <= cur_i <= max_i
    assert 0 <= cur_j <= max_j

    field[cur_i][cur_j].type = CELL_FILLED

    if on_cell_type_changed:
        on_cell_type_changed(cur_i, cur_j, CELL_FILLED)


@log_invocation
@internal
def cell_should_be_filled():

    return get_cell_type(cur_i, cur_j) == CELL_TO_BE_FILLED


@log_invocation
@public
def cell_is_filled():
    return get_cell_type(cur_i, cur_j) == CELL_FILLED


@log_invocation
@internal
def set_parking_cell(i, j):
    global field, max_i, max_j

    assert field
    assert 0 <= i <= max_i
    assert 0 <= j <= max_j

    field[i][j].parking_cell = True


@log_invocation
@internal
def is_parking_cell(i, j):
    global field, max_i, max_j

    assert field
    assert 0 <= i <= max_i
    assert 0 <= j <= max_j

    return field[i][j].parking_cell


@log_invocation
@internal
def is_parking_point():
    global field, cur_i, cur_j

    assert field
    assert 0 <= cur_i <= max_i
    assert 0 <= cur_j <= max_j

    return field[cur_i][cur_j].parking_cell


@log_invocation
@public
def mov(register, value):
    global registers

    assert registers is not None

    registers[register] = value


@log_invocation
@internal
def get_register_value(register):
    global registers

    assert registers is not None

    return registers.get(register, None)