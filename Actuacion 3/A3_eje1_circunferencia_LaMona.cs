using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 3 ejercicio 1
// Crea una función que calcule el área de un círculo dado su radio.
// La fórmula para calcular el área es A = π × r², donde r es el radio.
// Pasos:
// 1. Solicitar al usuario que ingrese el radio del círculo.
// 2. Validar que la entrada sea un número positivo.
// 3. Calcular el área usando la fórmula A = π × r².
// 4. Mostrar el resultado al usuario.

class Program
{
    static void Main()
    {
        double radio;

        // Solicita al usuario que ingrese el radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
        {
            Console.Write("Entrada inválida. Ingrese un número positivo para el radio: ");
        }

        // Calcula el área del círculo
        double area = CalcularAreaCirculo(radio);

        // Muestra el área calculada
        Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
    }

    // Función para calcular el área de un círculo
    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}
