using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 6
// Escribe un programa que solicita al usuario su edad y determina si tiene la edad suficiente para votar utilizando sentencias if.
// Pasos:
// 1. Pedir al usuario su edad.
// 2. Validar que la entrada sea un número entero positivo.
// 3. Usar una sentencia if para verificar si la edad es mayor o igual a 18.
// 4. Mostrar un mensaje indicando si el usuario puede votar o no.

class Program
{
    static void Main()
    {
        int edad;

        // Solicita al usuario que ingrese su edad
        Console.Write("Ingrese su edad: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("Entrada inválida. Ingrese una edad válida: ");
        }

        // Verifica si el usuario tiene la edad suficiente para votar
        if (edad >= 18)
        {
            Console.WriteLine("Usted puede votar.");
        }
        else
        {
            Console.WriteLine("Usted no tiene la edad suficiente para votar.");
        }
    }
}
