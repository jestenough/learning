#include <iostream>

/*
Последовательность состоит из натуральных чисел и завершается числом 0.
Определите значение наибольшего четного элемента последовательности. 
Числа, следующие за нулем, считывать не нужно.
*/

int main()
{
    uint32_t max = 0;
    uint32_t n;

    std::cout << "Enter the numbers. To STOP enter 0\n";
    while (true)
    {
        std::cout << ">>> ";
        std::cin >> n;

        if (n == 0)
            break;
        else if (n % 2 == 0)
            if (n > max)
                max = n;
    }

    std::cout << "Максимальное четное число: " << max << std::endl;

    return 0;
}
