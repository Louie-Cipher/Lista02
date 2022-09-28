using System;

namespace prj29000_Lista02_Ex02
{
    internal class C29000_Lista02_Ex02
    {
        static void Main()
        {
            int n1, n2;

            Console.Write("Digite o primeiro número: ");
            bool n1Valid = int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite o segundo número: ");
            bool n2Valid = int.TryParse(Console.ReadLine(), out n2);

            if (!n1Valid || !n2Valid) return;

            if (n1 > n2) Console.WriteLine($"O maior número é: {n1}");
            else if (n2 > n1) Console.WriteLine($"O maior número é: {n2}");
            else Console.WriteLine("Os números são iguais");

            Console.ReadKey();
        }
    }
}