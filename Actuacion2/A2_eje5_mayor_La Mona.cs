using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 5
// Escribe un programa que pide dos números al usuario y determina cuál es el mayor.
// Pasos:
// 1. Pedir al usuario el primer número.
// 2. Validar que la entrada sea un número entero.
// 3. Pedir al usuario el segundo número.
// 4. Validar que la entrada sea un número entero.
// 5. Comparar ambos números y determinar cuál es el mayor.
// 6. Mostrar el resultado al usuario.

class Program
{
    static void Main()
    {
        int numero1, numero2;

        // Solicita al usuario que ingrese el primer número
        Console.Write("Ingrese el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Entrada inválida. Ingrese un número entero válido: ");
        }

        // Solicita al usuario que ingrese el segundo número
        Console.Write("Ingrese el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Entrada inválida. Ingrese un número entero válido: ");
        }

        // Determina cuál es el mayor
        if (numero1 > numero2)
        {
            Console.WriteLine($"El número mayor es: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"El número mayor es: {numero2}");
        }
        else
        {
            Console.WriteLine("resulta que son iguales.");
        }
    }
}
