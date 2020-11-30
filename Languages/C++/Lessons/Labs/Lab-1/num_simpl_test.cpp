#include <iostream>
#include <cmath>

/*
Выяснить, является ли заданное число простым.
Вывести 1 - число простое, 0 - число составное.
*/

int main()
{
    uint32_t n;

    std::cout << "Enter the number:\n>>> ";
    std::cin >> n;

    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
        {
            std::cout << 0;
            return 0;
        }
    }
    std::cout << 1;
    return 0;

}
