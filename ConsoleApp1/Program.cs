 using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //int a = 12;
            //// Задание 2
            //double b = 4;
            //// Задание 3
            //var c = 32;
            //// Console.WriteLine(12%4);
            //int l = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int w = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(a*d*w);
            //if (l>d)
            //{
            //    Console.WriteLine(l);
            //}
            //else
            //{
            //    Console.WriteLine(d);
            //}
            //if (l % 2 == 0 & d%2 == 0)
            //{
            //    Console.WriteLine(l+d);
            //}
            //else
            //{
            //    Console.WriteLine(l*d);
            //}

            //while (true)
            //{
            //    Console.WriteLine("1");

            //}
            
            //{
            //    array[i] = int.Parse (Console.ReadLine());    
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //        Console.Write(array[i]); 
            //}
            int[] array = new int[5];
            
            Random h = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = h.Next();
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
