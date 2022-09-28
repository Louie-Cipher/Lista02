using System;

namespace prj29000_Lista02_Ex08
{
    internal class C29000
    {
        static void Main()
        {
            Console.Write("Digite o tamanho do lado A: ");
            bool aValid = float.TryParse(Console.ReadLine(), out float a);

            Console.Write("Digite o tamanho do lado B: ");
            bool bValid = float.TryParse(Console.ReadLine(), out float b);

            Console.Write("Digite o tamanho do lado C: ");
            bool cValid = float.TryParse(Console.ReadLine(), out float c);

            if (!aValid || !bValid || !cValid) return;

            if (a < b + c && b < a + c && c < a + b)
            {
                if (
                    a * a == b * b + c * c ||
                    b * b == a * a + c * c ||
                    c * c == a * a + b * b
                ) Console.WriteLine("É um triângulo retângulo");
                else Console.WriteLine("NÃO é um triângulo retângulo");
            }
            else Console.WriteLine("NÃO é um TRIÂNGULO");

            Console.ReadKey();
        }
    }
}