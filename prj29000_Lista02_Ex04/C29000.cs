using System;

namespace prj29000_Lista02_Ex04
{
    internal class C29000
    {
        static void Main()
        {
            Console.Write("Digite a base: ");
            bool wValid = int.TryParse(Console.ReadLine(), out int w);

            Console.Write("Digite a altura: ");
            bool hValid = int.TryParse(Console.ReadLine(), out int h);

            if (!wValid || !hValid) return;

            int area = h * w;

            Console.WriteLine($"\nA área é: {area}");

            if (area > 100) Console.WriteLine("Terreno grande");

            Console.ReadKey();
        }
    }
}