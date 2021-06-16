#include <vector>
#include <iostream>

// Перебор всех возможных чисел из заданных

int n, m;
std::vector<int> vec;

void out()
{
    for (int i = 0; i < n; i++)
    {
        if (i)
            std::cout << " ";
        std::cout << vec[i];
    }
    std::cout << std::endl;
}

void rec(int idx)
{
    if (idx == n)
    {
        out();
        return;
    }
    for (int i = 1; i <= m; i++)
    {
        vec[idx] = i;
        rec(idx + 1);
    }
}

int main()
{
    std::cin >> n >> m;
    vec = std::vector<int>(n);
    rec(0);

    return 0;
}
