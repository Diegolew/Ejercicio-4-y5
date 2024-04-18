// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una estación del año (primavera, verano, otoño, invierno):");
        string estacion = Console.ReadLine().ToLower();

        switch (estacion)
        {
            case "primavera":
                Console.WriteLine("La primavera en va desde el 21 de septiembre al 20 de diciembre.");
                break;
            case "verano":
                Console.WriteLine("El verano en va desde el 21 de diciembre al 20 de marzo.");
                break;
            case "otoño":
                Console.WriteLine("El otoño en va desde el 21 de marzo al 20 de junio.");
                break;
            case "invierno":
                Console.WriteLine("El invierno en va desde el 21 de junio al 20 de septiembre.");
                break;
            default:
                Console.WriteLine("Estación no válida. Por favor, ingresa una estación válida.")
                break;
        }
    }
}

