#include <iostream>
#include <climits>

/*
Последовательность состоит из натуральных чисел и завершается числом 0.
Определите, сколько элементов этой последовательности равны ее наибольшему элементy
(включая сам наибольший). Числа, следующие за числом 0, считывать не нужно. 
*/

int main()
{
    int max = 0;
    int n;
    int count;

    while (true)
    {
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

    std::cout << count << std::endl;

    return 0;
}
