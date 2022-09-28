using System;

namespace prj29000_Lista02_Ex09
{
    internal class C29000
    {
        static void Main()
        {
            Console.Write("Digite a nota da P1: ");
            bool p1Valid = float.TryParse(Console.ReadLine(), out float p1);

            Console.Write("Digite a nota da P2: ");
            bool p2Valid = float.TryParse(Console.ReadLine(), out float p2);

            if (!p1Valid || !p2Valid) return;

            Console.WriteLine((p1 + p2 * 2) / 3 >= 5 ? "Aprovado" : "Reprovado");
            Console.ReadKey();
        }
    }
}
