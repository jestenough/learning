#include <iostream>

/*
Последовательность состоит из натуральных чисел и завершается числом 0.
Определите значение наибольшего четного элемента последовательности. 
Числа, следующие за нулем, считывать не нужно.
*/

int main()
{
    int max = 0;
    int n;

    while (true)
    {
        std::cin >> n;

        if (n == 0)
            break;
        else if (n % 2 == 0)
            if (n > max)
                max = n;
    }

    std::cout <<  max << std::endl;

    return 0;
}
