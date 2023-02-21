using System;

namespace Fibonacci_Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int derinlik;

            Console.WriteLine("Fibonacci Derinliği Giriniz: ");
            derinlik =int.Parse(Console.ReadLine());

            int[] fib = new int[derinlik];
            fib[0]=0;

            if(derinlik>1)
            {
                fib[1]=1;
            }

            for (int i = 2; i < derinlik; i++)
            {
                fib[i]=fib[i-1] + fib[i-2];
            }

            int sum = 0;

            for (int i = 0; i < derinlik; i++)
            {
                sum = sum + fib[i];
            }

            double ortalama = sum / derinlik;
            Console.WriteLine("Fibonacci serisi ortalaması: "+ ortalama);
        }
    }
}
