using System;

namespace IEnumerableInterfaces
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Odd Numbers: ");

            var generartor = new OddGenerator();
            foreach (var odd in generartor)
            {
                if (odd > 50) break;
                Console.WriteLine(odd);
            }

            Console.ReadKey();
        }
    }
}
