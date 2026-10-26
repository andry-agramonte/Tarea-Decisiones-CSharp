
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite la nota: ");
        int nota = int.Parse(Console.ReadLine());

        string letra = "";
        string estado = "";

        if (nota >= 90 && nota <= 100)
        {
            letra = "A";
            estado = "Aprobado";
        }
        else if (nota >= 80 && nota <= 89)
        {
            letra = "B";
            estado = "Aprobado";
        }
        else if (nota >= 70 && nota <= 79)
        {
            letra = "C";
            estado = "Aprobado";
        }
        else
        {
            letra = "F";
            estado = "Reprobado";
        }

        Console.WriteLine($"\nCalificación: {letra}");
        Console.WriteLine($"Estado: {estado}");
    }
}
