using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            string s = "боится,какчертладана";
            string key = "знамя";
            //string s = "близоклокоть,данеукусишь";
            //string key = "долина";
            char[] s1 = s.ToCharArray();
            int n = s.Length / key.Length;
            int m = key.Length;
            char[,] s2 = new Char[n, m];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    s2[i, j] = s1[k];
                    k++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(s2[i, j] + " ");
                }
                Console.WriteLine();
            }       
        }
    }
}
