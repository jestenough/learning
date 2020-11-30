#include <iostream>
#include <stdio.h>

/*
Необходимо найти НОД двух чисел,
используя алгоритм Евклида.
*/

int euclid_find(int x1, int x2)
{
    while (x1 != x2)
    {
        if (x1 > x2)
            x1 -= x2;
        else
            x2 -= x1;
    }
    return x1;
}

int main()
{
    int x, y;

    std::cout << "Enter x:\n>>> ";
    std::cin >> x;
    std::cout << "Enter y:\n>>> ";
    std::cin >> y;

    printf("НОД чисел %d и %d = ", x, y);
    std::cout << euclid_find(x, y) << std::endl;
    
    return 0;
}
