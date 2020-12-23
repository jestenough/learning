#include <iostream>

/*
Входные данные подаются построчно, в каждой строке − скорость (целое число) 
и номер автомобиля (6 символов − 1 латинская буква, 3 цифры и ещё 2 латинские буквы). 
Штраф для автомобильных номеров зависит от количества совпадающих цифр: 
три совпадают − 1000 у.е., две любые цифры совпадают − 500 у.е., все цифры разные − 100 у.е. 

Количество входных строк заранее не известно.
Номер начальника A999AA, где A — латинская буква. 
Если кто-то приезжает после начальника, их штрафовать не требуется. 
*/

int main()
{
    int speed;
    std::string number;

    int salary = 0;
    
    int digit1;
    int digit2;
    int digit3;

    while (true)
    {
        std::cin >> speed >> number;
        
        digit1 = number[1];
        digit2 = number[2];
        digit3 = number[3];

        if (number == "A999AA")
            break;

        if (speed > 60)
        {
            if ((digit1 == digit2) and (digit1 == digit3))
                salary += 1000;
            else if ((digit1 == digit2) or (digit1 == digit3) or (digit2 == digit3))
                salary += 500;
            else
                salary += 100;
        }

    }

    std::cout << salary << std::endl;
    return 0;
}
