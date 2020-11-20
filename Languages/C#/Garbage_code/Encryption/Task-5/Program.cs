using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ЛЬИДЬКЮ__Е_УБ_ННЗПО_ЕЬАИВ__Г_Ш";
            char[] m1 = s.ToCharArray();
            int n = 5;
            int m = 6;
            char[,] m2 = new char[n, m];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (k < m1.Length)
                        m2[i, j] = m1[k];
                    k = k + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(m2[i, j] + " ");
                }
                Console.WriteLine();
            }
            char[,] m6 = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                m6[i, 0] = m2[i, 0];
                m6[i, 1] = m2[i, 4];
                m6[i, 2] = m2[i, 3];
                m6[i, 3] = m2[i, 2];
                m6[i, 4] = m2[i, 5];
                m6[i, 5] = m2[i, 1];
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(m6[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
