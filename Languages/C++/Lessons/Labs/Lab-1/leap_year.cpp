#include <iostream>

/*
Требуется определить, является ли данный год високосным. 
(Год является високосным, если его номер кратен 4, но не кратен 100, а также если он кратен 400). 
*/

int main()
{
    int N;
    
    std::cin >> N;
    
    if (N % 4 == 0)
    {
        if (N % 100 == 0)
        {
            if (N % 400 == 0)
                std::cout << "YES";
            else
                std::cout << "NO";
        }
        else
            std::cout << "YES";
    }
    else
    {
        std::cout << "NO";
    }

    return 0;
}
