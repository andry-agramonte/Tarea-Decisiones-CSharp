
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Resultado: Puede votar.");
        }
        else
        {
            Console.WriteLine("Resultado: No puede votar.");
        }
    }
}
