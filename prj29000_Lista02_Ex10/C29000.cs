using System;

namespace prj29000_Lista02_Ex10
{
    internal class C29000
    {
        static void Main()
        {
            Console.Write("Digite a nota da P1: ");
            if (!float.TryParse(Console.ReadLine(), out float p1)) return;
            Console.WriteLine($"Para passar, é necessário tirar no mínimo {(5 * 3 - p1) / 2} na P2.");
            Console.ReadKey();
        }
    }
}