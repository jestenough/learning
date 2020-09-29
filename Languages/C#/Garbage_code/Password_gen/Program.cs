using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char password;

            int L = 0;
            
  	        double T = 6.0 / 7.0;
            //Console.WriteLine("Максимальный срок действия пароля = {0} недель",T);
	          double P = Math.Pow(10, -7);
            //Console.WriteLine("Вероятность подбора пароля = {0}",P);
	          int V = 11*60*24*7;
            //Console.WriteLine("Скорость перебора паролей  = {0} в неделю",V);
        
            Console.WriteLine("\n---------------------------------------");

            int A = dictionary.Length;
            Console.WriteLine("Мощность алфавита паролей = {0}", A);

            double S = (V * T) / P;
            Console.WriteLine("Нижняя граница пароля = {0}", S);
            
            while(S >= Math.Pow(A,L))   L++;
	          Console.WriteLine("Длина пароля (L) = {0}", L);

            Random randik = new Random();
            Console.Write("Ваш пароль: ");
            for (int i = 0; i <= L; i++)
            {
                password = dictionary[randik.Next(0, A + 1)];
                Console.Write(password); 
            }

            Console.WriteLine("\n---------------------------------------");
        }
    }
}
