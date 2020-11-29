#include <iostream>
#include <cstring> 
// #include <windows.h> 

void SetColor(int,int);
bool palindrome(std::string);
void again_or_not(std::string);

int main()
{
	std::string word, again; 
	
	while (true)
	{
			SetColor(14,0);  
			std::cout << "\t\t\t\t \\ PALINDROME \\ \n\n";
			SetColor(15,0);
			std::cout << "\n> Enter the word: ";
			std::cin >> word;
				for (int z=0; z < word.size(); z++)  
				{
						word[z] = (char)tolower(word[z]); 
				}
			
			if (palindrome(word)) 
			{
					SetColor(10,0);
					std::cout << "\n===================";
					std::cout << "\n> is a Palindrome!|" << "\n";
					std::cout << "===================" << "\n\n";
					again_or_not(again);					
			}
			else  
			{
					SetColor(4,0);
					std::cout << "\n----------------------";
					std::cout << "\n> is not a Palindrome|" << "\n";
					std::cout << "----------------------" << "\n\n";
					again_or_not(again);
			}
	}
	
	system("pause");
	return 0;
}

void SetColor(int text, int bg) 
{
	//HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);  
    //SetConsoleTextAttribute(hStdOut, (WORD)((bg << 4) | text)); 
}

bool palindrome(std::string word)
{
	int size; 
	size = word.size();
	
	for (int x = 0; x < size/2; ++x) 
	{
			if(word[x] != word[size-x-1])
			{
					return false;
			}
	}
	return true;
}

void again_or_not(std::string again) 
{
	while (true)
	{
			SetColor(14,0);
			std::cout << "U wanna test again? -- (Y)es/(N)o \n> ";
			std::cin >> again;
			if (again == "Y" || again == "y")
			{
					system("cls"); 
					break;
			}
			else if (again == "N" || again == "n")
			{	
					system("cls");
					SetColor(2,0);
					std::cout << "> See u next time!\n\n";
					SetColor(15,0);
					system("pause"); 
					exit(0);
			}
			else
			{
					SetColor(4,0);
					std::cout << "Error. Try again\n";
					continue;
			}
	}
}
