using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Actuación en clase 2 ejercicio 4
// Escribe un programa que pide al usuario un número entero y determina si es par o impar.
// Pasos:
// 1. Pedir al usuario un número entero.
// 2. Validar que la entrada sea un número entero.
// 3. Determinar si el número es par o impar usando el operador módulo (%).
// 4. Mostrar el resultado al usuario.

class Program
{
    static void Main()
    {
        int numero;

        // Solicita al usuario que ingrese un número entero
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Ingrese un número entero válido: ");
        }

        // Determina si el número es par o impar
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}
