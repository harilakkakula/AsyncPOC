using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPOC
{
    class Program
    {
        async static Task  Main(string[] args)
        {
            Console.WriteLine("jkjk Press any key to exit...");
            Sum();
            Console.WriteLine("await Press any key to exit...");
            Console.ReadLine();
        }
        
        public async static Task checkAsync()
        {
           int count= await Sum();
            Console.WriteLine(count);
        }
        public static async Task<int> Sum()
        {
            await Task.Delay(5000);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Console.WriteLine("complterd sum ietration");
            return 3;
        }

        class Maths
        {
           
            public static Task<int> mul(int a, int b)
            {
                Thread.Sleep(2000);
                return Task.FromResult(a * b);
            }

            public static int Division(int a, int b)
            {
                Thread.Sleep(2000);
                return a / b;
            }
        }
       
    }
}
