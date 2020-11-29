#include <iostream>
#include <cstdlib>
#include <ctime>

int main()
{
	setlocale(LC_ALL,"rus");
	srand(time(0));
	
	const char stroka[] = "abcdefghijklmnopqrstuvwxyz1234567890-!@#$%^&*()=+ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	int length;
	
	std::cout << "Введите размер пароля > ";
	std::cin >> length;
	
	char password[length];

	for (int i = 0; i < length; i++)
	{
		password[i] = stroka[rand()%sizeof(stroka)/sizeof(stroka[0])];
	}
	
	std::cout << "Ваш пароль > " << password << '\n' << '\n';
	
	return 0;
}
