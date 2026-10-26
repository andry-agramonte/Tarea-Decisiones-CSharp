
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Monto total de la compra (RD$): ");
        double montoCompra = double.Parse(Console.ReadLine());

        double descuentoAplicado = 0;
        string porcentajeStr = "";

        if (montoCompra >= 10000)
        {
            descuentoAplicado = montoCompra * 0.15;
            porcentajeStr = "15%";
        }
        else
        {
            descuentoAplicado = montoCompra * 0.05;
            porcentajeStr = "5%";
        }

        double totalPagar = montoCompra - descuentoAplicado;

        Console.WriteLine($"\nNombre del cliente: {cliente}");
        Console.WriteLine($"Monto de compra: RD${montoCompra:N2}");
        Console.WriteLine($"Descuento aplicado: {porcentajeStr} (RD${descuentoAplicado:N2})");
        Console.WriteLine($"Total a pagar: RD${totalPagar:N2}");
    }
}
