using System;

namespace Task_1
{
    class ClassCounter 
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;

        public void Count()
        {          
            for (int i = 1; i <= 100; i++)  
            {  
                Console.Write(i + " ");
                if (i == 100)
                {
                    if (onCount != null)
                    {
                        onCount();
                    }
                }
            }         
        }
    }
    class Handler_I 
    {
        public void Message()
        {
            Console.WriteLine("Пора действовать, ведь уже 100!");         
        }                                                        
    }
    class Handler_II
    {
        public void Message()
        {            
            Console.WriteLine("Точно, уже 100!");        
        }    
    }


    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();
            
            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;
            Counter.Count();
        }
    }
}
