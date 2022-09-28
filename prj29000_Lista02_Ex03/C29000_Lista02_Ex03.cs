using System;
namespace prj29000_Lista02_Ex03
{
    internal class C29000_Lista02_Ex03
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            bool n1Valid = int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Digite o segundo número: ");
            bool n2Valid = int.TryParse(Console.ReadLine(), out int n2);

            Console.Write("Digite o terceiro número: ");
            bool n3Valid = int.TryParse(Console.ReadLine(), out int n3);

            if (!n1Valid || !n2Valid || !n3Valid) return;
            
            int[] arr = { n1, n2, n3 };

            Array.Sort(arr);

            Console.WriteLine("O maior número é: " + arr[2]);
            Console.ReadKey();
        }
    }
}