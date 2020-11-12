using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            string s = "автотрансформатор";
            //string s = "проницательность";
            char[] s1 = s.ToCharArray();
            char[,] s2 = new Char[4,4];
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                        s2[j, i] = s1[k];
                        k++;
                }
            }
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                    Console.Write(s2[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < s2.GetLength(0); i++)
            {
                for (int j = 0; j < s2.GetLength(1); j++)
                {
                    Console.Write(s2[i, j]);
                }
            }        }
    }
}
