#include <iostream>

/*
Требуется определить, является ли данный год високосным. 
(Год является високосным, если его номер кратен 4, но не кратен 100, а также если он кратен 400). 
*/

void leap_year_find(uint32_t x1)
{
    if ((x1 % 4 == 0 or x1 % 400 == 0) and (x1 % 100 != 0))
        std::cout << "YES\n";
    else
        std::cout << "NO\n";
}

int main()
{
    uint32_t N;
    
    std::cout << "Enter year number:\n>>> ";
    std::cin >> N;
    
    leap_year_find(N);
    
    return 0;
}
