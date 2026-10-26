
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("Resultado: Número positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Resultado: Número negativo");
        }
        else
        {
            Console.WriteLine("Resultado: El número es cero.");
        }
    }
}
