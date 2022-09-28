using System;

namespace prj29000_Lista02_Ex06
{
    internal class C29000
    {
        static void Main()
        {
            Console.Write("Digite seu peso em kg: ");
            bool kgValid = float.TryParse(Console.ReadLine(), out float kg);
            
            Console.Write("Digite sua altura em metros: ");
            bool mValid = float.TryParse(Console.ReadLine(), out float m);

            if (!kgValid || !mValid) return;

            double imc = kg / Math.Pow(m, 2);

            if (imc < 20) Console.WriteLine("Abaixo do peso");
            else if (imc >= 20 && imc < 25) Console.WriteLine("Peso ideal");
            else Console.WriteLine("Acima do peso");

            Console.ReadKey();
        }
    }
}