using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ЙИРЕИК_КАТ,ЛЧИШК";
            //string s = "ЙИРЕО СНЕЙ_ЛВОПК";
            char[] s1 = s.ToCharArray();
            char[] s2 = new Char[16];
            s2[0] = s1[15];
            s2[1] = s1[2];
            s2[2] = s1[1];
            s2[3] = s1[12];
            s2[4] = s1[4];
            s2[5] = s1[9];
            s2[6] = s1[10];
            s2[7] = s1[7];
            s2[8] = s1[8];
            s2[9] = s1[5];
            s2[10] = s1[6];
            s2[11] = s1[11];
            s2[12] = s1[3];
            s2[13] = s1[14];
            s2[14] = s1[13];
            s2[15] = s1[0];
            Console.WriteLine(s2);
        }
    }
}
