using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Program
{
    static void Main()
    {
        // 1. Evaluar si un número es positivo, negativo o cero
        Console.Write("Ingrese un número: ");
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine();

        // 2. Evaluar calificación
        Console.Write("Ingrese una calificación: ");
        if (int.TryParse(Console.ReadLine(), out int calificacion))
        {
            Console.WriteLine(calificacion >= 60 ? "Aprobado" : "Reprobado");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine();

        // 3. Determinar el rango de un número
        Console.Write("Ingrese un número para verificar su rango: ");
        if (int.TryParse(Console.ReadLine(), out int numRango))
        {
            if (numRango < 10)
                Console.WriteLine("Menor que 10");
            else if (numRango >= 10 && numRango <= 20)
                Console.WriteLine("Entre 10 y 20");
            else
                Console.WriteLine("Mayor que 20");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine();

        // 4. Día de la semana
        Console.Write("Ingrese un número del 1 al 7: ");
        if (int.TryParse(Console.ReadLine(), out int dia))
        {
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            if (dia >= 1 && dia <= 7)
                Console.WriteLine("El día correspondiente es: " + diasSemana[dia - 1]);
            else
                Console.WriteLine("Número fuera de rango.");
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
        Console.WriteLine();

        // 5. Calculadora básica con switch
        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.Write("Ingrese la operación (+, -, *, /): ");
                char operacion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (operacion)
                {
                    case '+':
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("No se puede dividir por cero.");
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }
}
