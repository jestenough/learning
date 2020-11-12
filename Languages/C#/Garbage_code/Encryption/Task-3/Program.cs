using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6, m = 6, k = 0;
            string s = "ГБАТ-ЯДО-,И-ЕВС--Н-ЬОТГЕЛ-ВАОТЮДЕМР-";
            //string s = "К--ГТВТООСО--ТТЖРА-ИАЕДВНТОЕО,ЛТ";
            char[] s1 = s.ToCharArray();
            char[,] s2 = new Char[n, m];
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                    s2[i, j] = s1[k];
                    k++;
                }
            }
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                    Console.Write(s2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                    Console.Write(s2[j, i]);
                }
            }        }
    }
}
