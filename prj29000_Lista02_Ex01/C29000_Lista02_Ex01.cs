using System;

namespace prj29000_Lista02_Ex01
{
    internal class C29000_Lista02_Ex01
    {
        static void Main()
        {
            Console.Write("Digite o 1° número: ");
            bool n1Valid= int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Digite o 2° número: ");
            bool n2Valid = int.TryParse(Console.ReadLine(), out int n2);

            if (!n1Valid || !n2Valid) return;
            
            Console.WriteLine($"O maior número é: {(n1 > n2 ? n1 : n2)}");
            Console.ReadKey();
        }
    }
}