using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Figura> figuras = new List<Figura>
        {
            new Figura(),
            new Rectangulo(2, 3),
            new Triangulo(4, 5)
        };

        foreach (Figura f in figuras)
        {
            Console.WriteLine($"{f.Nombre()}: {f.Area()}");
        }


        Console.WriteLine(Suiche.Describir(42));
        Console.WriteLine(Suiche.Describir("hola"));
        Console.WriteLine(Suiche.Describir(null!));
        Console.WriteLine(Suiche.Describir(3.5));

        Producto producto = new Producto("Café", 4500);
        Console.WriteLine(producto.ToString());
    }
}