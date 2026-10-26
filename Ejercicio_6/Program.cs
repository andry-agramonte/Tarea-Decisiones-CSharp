
using System;

class Program
{
    static void Main()
    {
        Console.Write("Saldo actual: ");
        double saldoActual = double.Parse(Console.ReadLine());

        Console.Write("Monto que desea retirar: ");
        double montoRetirar = double.Parse(Console.ReadLine());

        if (montoRetirar > 0 && montoRetirar <= saldoActual)
        {
            double saldoRestante = saldoActual - montoRetirar;

            Console.WriteLine("\nTransacción aprobada.");
            Console.WriteLine($"Saldo restante: RD${saldoRestante:N2}");
        }
        else
        {
            Console.WriteLine("\nFondos insuficientes");
        }
    }
}
