// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número romano del I al XX:");
        string numeroRomano = Console.ReadLine().ToUpper();

        int valorEntero = -1;
        string[] numerosRomanos = {
            "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X",
            "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX"
        };

        for (int i = 0; i < numerosRomanos.Length; i++)
        {
            if (numeroRomano == numerosRomanos[i])
            {
                valorEntero = i + 1;
                break;
            }
        }

        if (valorEntero != -1)
        {
            Console.WriteLine($"El valor entero de '{numeroRomano}' es: {valorEntero}");
        }
        else
        {
            Console.WriteLine("Número romano no válido. Por favor, ingresa un número romano del I al XX.");
        }
    }
}