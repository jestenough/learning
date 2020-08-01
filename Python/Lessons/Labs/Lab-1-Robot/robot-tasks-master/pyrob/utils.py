#!/usr/bin/python3

import sys
import functools
import logging

logger = logging.getLogger(__name__)


def log_invocation(f):

    @functools.wraps(f)
    def wrapper(*args, **kwargs):
        logger = sys.modules[f.__module__].logger
        logger.debug('Calling function {} with arguments: args={}, kwargs={}'.format(f.__name__, args, kwargs))
        ret = f(*args, **kwargs)
        logger.debug('Return value of {} is {}'.format(f.__name__, ret))
        return ret

    return wrapper


class AllowInternalContext():

    _allow_internal = False

    @classmethod
    def internal_allowed(cls):
        return cls._allow_internal

    @classmethod
    def allow_internal(cls, flag):
        cls._allow_internal = flag

    @log_invocation
    def __init__(self, allow):
        self.flag = AllowInternalContext._allow_internal
        self.allow = allow

    @log_invocation
    def __enter__(self):
        AllowInternalContext._allow_internal = self.allow

    @log_invocation
    def __exit__(self, *args):
        AllowInternalContext._allow_internal = self.flag


def allow_internal(flag, ctx=True):
    if ctx:
        return AllowInternalContext(flag)
    else:
        AllowInternalContext.allow_internal(flag)

def internal(f):

    @functools.wraps(f)
    def wrapper(*args, **kwargs):
        if not AllowInternalContext.internal_allowed():
            raise NotImplementedError("API {} is marked as internal".format(f.__name__))
        return f(*args, **kwargs)

    return wrapper


def public(f):

    @functools.wraps(f)
    def wrapper(*args, **kwargs):
        with allow_internal(True):
            return f(*args, **kwargs)

    return wrapper


def repeat(n, f, *args, **kwargs):
    assert n > 0
    for i in range(n):
        f(*args, **kwargs)