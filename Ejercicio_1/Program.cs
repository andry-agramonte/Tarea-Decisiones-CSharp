
using System;

class Program
{
    static void Main()
    {
        string nombre;
        double nota;

        Console.Write("Ingrese el nombre del estudiante: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese la nota del estudiante: ");
        nota = double.Parse(Console.ReadLine());

        Console.WriteLine("Estudiante: " + nombre);

        if (nota >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}
