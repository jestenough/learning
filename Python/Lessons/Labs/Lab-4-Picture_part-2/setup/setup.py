# -*- coding: utf-8 -*-
from distutils.core import setup
setup(
    name='graph',
    version='1.5.0',
    py_modules=['graph'],
    requires = ["tkinter"],
    description = "Graph - tkinter-based framework for simple Python graphics",
    author = "Konstantin Polyakov",
    author_email = "kpolyakov@mail.ru",
    maintainer = "Konstantin Polyakov",
    maintainer_email = "kpolyakov@mail.ru",
    url = "http://kpolyakov.spb.ru/school/probook/python.htm",
    download_url = "http://kpolyakov.spb.ru/school/probook/python.htm",
    keywords = ["application", "framework", "tkinter", "graphics"],
    classifiers = [
        "Development Status :: 3 - Alpha",
        "Environment :: Other Environment",
        "Intended Audience :: Developers",
        "License :: OSI Approved :: MIT licence",
        "Operating System :: OS Independent",
        "Programming Language :: Python",
        "Programming Language :: Python :: 3",
        "Programming Language :: Python :: 3.2",
        "Topic :: Software Development",
        "Topic :: Software Development :: Build Tools",
        "Topic :: Software Development :: Libraries :: Application Frameworks",
        "Topic :: Software Development :: Libraries :: Python Modules",
        "Topic :: Software Development :: User Interfaces",
    ],
    license = """
Licensed under MIT licence.
    """,
    long_description = """
Graph: tkinter-based framework for simple graphics

`Graph` is a **Python3.2+** library designed to simplifying
coordinate graphics on the basis of tkinter library.
"""
    )
