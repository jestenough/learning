#include <iostream>

/*
Посчитать количество четных чисел в последовательсти. 
Последовательность целых чисел заканчивается нулём. Ноль не входит в последовательность. 
*/

int main()
{
    int x;
    int count = 0;
    std::cout << "Enter the number. To STOP enter 0\n";
    while (true)
    {
        std::cout << ">>> ";
        std::cin >> x;

        if (x == 0)
            break;
        else if (x % 2 == 0)
            count++;
    }

    std::cout << "\nКоличество четных чисел = " << count << std::endl;
    return 0;
}   
