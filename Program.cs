using System;
namespace blokcxema.zadacha_7.sem2
{
    class Program
    {
        static void Main()
        {
            int a, n, i;
            try
            {
                Console.WriteLine("Введите количество элементов массива ");
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) { Main(); }
                return;
            }
            Random rand = new Random();
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                array[i] = rand.Next(-2, 4);
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    continue;
                }
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) { Main(); }
            return;
        }
    }
}
