import unittest

import pyrob.core as rob
import pyrob.utils


class BasicTest(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        pyrob.utils.allow_internal(True, False)

    def testSetFieldSize(self):
        for (m, n) in [(10, 10), (10, 20), (20, 10)]:
            rob.set_field_size(m, n)

            for i in range(m):
                self.assertTrue(rob.is_blocked(i, 0, rob.WALL_LEFT))
                self.assertTrue(rob.is_blocked(i, n - 1, rob.WALL_RIGHT))
            for i in range(n):
                self.assertTrue(rob.is_blocked(0, i, rob.WALL_TOP))
                self.assertTrue(rob.is_blocked(m - 1, i, rob.WALL_BOTTOM))

        with self.assertRaises(AssertionError):
            rob.set_field_size(0, 0)

        with self.assertRaises(AssertionError):
            rob.set_field_size(0, 1)

        with self.assertRaises(AssertionError):
            rob.set_field_size(1, 0)

        with self.assertRaises(AssertionError):
            rob.set_field_size(2, -1)

        with self.assertRaises(AssertionError):
            rob.set_field_size(-1, 2)

    def testPutWall(self):
        rob.set_field_size(4, 4)

        rob.goto(1, 1)
        rob.put_wall(right=True, bottom=True)

        rob.goto(2, 2)
        rob.put_wall(left=True, top=True)

        self.assertTrue(rob.is_blocked(1, 1, rob.WALL_RIGHT))
        self.assertTrue(rob.is_blocked(1, 1, rob.WALL_BOTTOM))
        self.assertFalse(rob.is_blocked(1, 1, rob.WALL_LEFT))
        self.assertFalse(rob.is_blocked(1, 1, rob.WALL_TOP))

        self.assertTrue(rob.is_blocked(1, 2, rob.WALL_LEFT))
        self.assertTrue(rob.is_blocked(1, 2, rob.WALL_BOTTOM))
        self.assertFalse(rob.is_blocked(1, 2, rob.WALL_RIGHT))
        self.assertFalse(rob.is_blocked(1, 2, rob.WALL_TOP))

        self.assertTrue(rob.is_blocked(2, 1, rob.WALL_RIGHT))
        self.assertTrue(rob.is_blocked(2, 1, rob.WALL_TOP))
        self.assertFalse(rob.is_blocked(2, 1, rob.WALL_LEFT))
        self.assertFalse(rob.is_blocked(2, 1, rob.WALL_BOTTOM))

        self.assertTrue(rob.is_blocked(2, 2, rob.WALL_LEFT))
        self.assertTrue(rob.is_blocked(2, 2, rob.WALL_TOP))
        self.assertFalse(rob.is_blocked(2, 2, rob.WALL_RIGHT))
        self.assertFalse(rob.is_blocked(2, 2, rob.WALL_BOTTOM))

        for i in 1, 2:
            self.assertTrue(rob.is_blocked(0, i, rob.WALL_TOP))
            self.assertFalse(rob.is_blocked(0, i, rob.WALL_BOTTOM))
            self.assertFalse(rob.is_blocked(0, i, rob.WALL_LEFT))
            self.assertFalse(rob.is_blocked(0, i, rob.WALL_RIGHT))

            self.assertTrue(rob.is_blocked(3, i, rob.WALL_BOTTOM))
            self.assertFalse(rob.is_blocked(3, i, rob.WALL_TOP))
            self.assertFalse(rob.is_blocked(3, i, rob.WALL_LEFT))
            self.assertFalse(rob.is_blocked(3, i, rob.WALL_RIGHT))

        for i in 1, 2:
            self.assertTrue(rob.is_blocked(i, 0, rob.WALL_LEFT))
            self.assertFalse(rob.is_blocked(i, 0, rob.WALL_BOTTOM))
            self.assertFalse(rob.is_blocked(i, 0, rob.WALL_TOP))
            self.assertFalse(rob.is_blocked(i, 0, rob.WALL_RIGHT))

            self.assertTrue(rob.is_blocked(i, 3, rob.WALL_RIGHT))
            self.assertFalse(rob.is_blocked(i, 3, rob.WALL_BOTTOM))
            self.assertFalse(rob.is_blocked(i, 3, rob.WALL_TOP))
            self.assertFalse(rob.is_blocked(i, 3, rob.WALL_LEFT))

        self.assertTrue(rob.is_blocked(0, 0, rob.WALL_LEFT))
        self.assertTrue(rob.is_blocked(0, 0, rob.WALL_TOP))
        self.assertFalse(rob.is_blocked(0, 0, rob.WALL_RIGHT))
        self.assertFalse(rob.is_blocked(0, 0, rob.WALL_BOTTOM))

        self.assertTrue(rob.is_blocked(0, 3, rob.WALL_RIGHT))
        self.assertTrue(rob.is_blocked(0, 3, rob.WALL_TOP))
        self.assertFalse(rob.is_blocked(0, 3, rob.WALL_LEFT))
        self.assertFalse(rob.is_blocked(0, 3, rob.WALL_BOTTOM))

        self.assertTrue(rob.is_blocked(3, 0, rob.WALL_LEFT))
        self.assertTrue(rob.is_blocked(3, 0, rob.WALL_BOTTOM))
        self.assertFalse(rob.is_blocked(3, 0, rob.WALL_RIGHT))
        self.assertFalse(rob.is_blocked(3, 0, rob.WALL_TOP))

        self.assertTrue(rob.is_blocked(3, 3, rob.WALL_RIGHT))
        self.assertTrue(rob.is_blocked(3, 3, rob.WALL_BOTTOM))
        self.assertFalse(rob.is_blocked(3, 3, rob.WALL_LEFT))
        self.assertFalse(rob.is_blocked(3, 3, rob.WALL_TOP))

