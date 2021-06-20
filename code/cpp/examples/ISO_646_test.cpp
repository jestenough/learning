#include <iostream>
#include <ciso646>

int main()
{
    uint8_t x, y;

    x = 5;
    y = 6;

    std::cout << (unsigned int) (x bitand y) << std::endl;
    std::cout << (unsigned int) (x bitor y) << std::endl;
    std::cout << (unsigned int) (x xor y) << std::endl;
    std::cout << (unsigned int) (compl x) << std::endl;
    y = compl x;
    std::cout << (unsigned int) (y) << std::endl;
}
