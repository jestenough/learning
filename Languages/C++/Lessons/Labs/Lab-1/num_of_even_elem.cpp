#include <iostream>

/*
Посчитать количество четных чисел в последовательсти. 
Последовательность целых чисел заканчивается нулём. Ноль не входит в последовательность. 
*/

int main()
{
    int x;
    int count = 0;
    while (true)
    {
        std::cin >> x;

        if (x == 0)
            break;
        else if (x % 2 == 0)
            count++;
    }

    std::cout << count << std::endl;
    return 0;
}   
