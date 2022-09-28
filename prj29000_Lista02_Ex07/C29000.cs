using System;

namespace prj29000_Lista02_Ex07
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

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.Write("Esse é um triângulo ");
                if (a == b && b == c) Console.WriteLine("equilátero");
                else if (a == b || b == c || a == c)  Console.WriteLine("isósceles");
                else Console.WriteLine("escaleno");
            }
            else Console.WriteLine("NÃO é um triângulo");
            

            Console.ReadKey();
        }
    }
}
