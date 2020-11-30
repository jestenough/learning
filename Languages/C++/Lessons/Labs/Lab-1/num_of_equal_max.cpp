#include <iostream>
#include <climits>

/*
Последовательность состоит из натуральных чисел и завершается числом 0.
Определите, сколько элементов этой последовательности равны ее наибольшему элементy
(включая сам наибольший). Числа, следующие за числом 0, считывать не нужно. 
*/

int main()
{
    uint32_t max = 0;
    uint32_t n;
    uint32_t count;

    std::cout << "Enter the numbers. To STOP enter 0\n";
    while (true)
    {
        std::cout << ">>> ";
        std::cin >> n;
        
        if (n == 0)
            break;
        
        if (n > max)
        {
            max = n;
            count = 1;
        }
        else if (n == max)
            count++;
    }

    std::cout << "Количество элементов, равных максимуму: " << count << std::endl;

    return 0;
}
