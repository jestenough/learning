// using System;

// namespace Task_5
// {
//     class Program
//     {
//         /*
//         Описать функцию IsPalindrom(K), возвращающую TRUE, 
//         если целый параметр K (> 0) является палиндромом, 
//         и FALSE в противном случае. 
//         С ее помощью найти количество палиндромов в наборе из 10 целых положительных чисел. 
//         */

//         static bool IsPalindrom(int K)
//         {
//             int size = 0;
            
//             for(int i = K; i != 0; i/=10)  size++;

//             Console.WriteLine(size);

//             for (int i = 2; i <= (size+1) / 2; i++)
//             {
//                 for (int x = 1; i <= (size+1);)
//                 {
//                     x*=10;
//                     for(int j = 1; i <= (size+1) / 2;)
//                     {
//                         j*=10;
//                         if (K % j / x != K / 10 / Math.Pow(10,size-i))  return false;
//                     }
//                 }
//             }
//             return true;
//         }
//         static void Main(string[] args)
//         {
//             int K;
//             Console.Write("Введите число: ");
//             K = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine(IsPalindrom(K));

//         }
//     }
// }
