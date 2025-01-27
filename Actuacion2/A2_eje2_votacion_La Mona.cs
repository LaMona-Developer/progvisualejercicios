using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Actuación en clase 2 ejercicio 2
// Escribe un programa que pida la edad del usuario y determine si puede votar (mayor o igual a 18 años).
// Pasos:
// 1. Pide la edad.
// 2. Si la edad es menor de 18 años, mostrar "No tiene la edad para votar".
// 3. Si la edad es mayor o igual a 18 años, mostrar "Usted está obligado a votar".

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

        // Verifica si el usuario puede votar
        if (edad < 18)
        {
            Console.WriteLine("No tiene la edad para votar."); // Paso 2: Mensaje si es menor de 18 años
        }
        else
        {
            Console.WriteLine("Usted está obligado a votar."); // Paso 3: Mensaje si es mayor o igual a 18 años
        }
    }
}
