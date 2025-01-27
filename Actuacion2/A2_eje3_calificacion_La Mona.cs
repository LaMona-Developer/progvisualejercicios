using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 3
// Escribe un programa que convierta una calificación numérica (0-100) en una letra según el criterio establecido.
// Criterio de calificación:
// 90-100: A
// 80-89: B
// 70-79: C
// 60-69: D
// 0-59: F

class Program
{
    static void Main()
    {
        int calificacion;

        // Solicita al usuario que ingrese una calificación numérica
        Console.Write("Ingrese una calificación (0-100): ");
        while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)
        {
            Console.Write("Entrada inválida. Ingrese una calificación válida entre 0 y 100: ");
        }

        // Determina la calificación en letra según el criterio
        char letra = calificacion >= 90 ? 'A' :
                     calificacion >= 80 ? 'B' :
                     calificacion >= 70 ? 'C' :
                     calificacion >= 60 ? 'D' : 'F';

        // Muestra la calificación en letra
        Console.WriteLine($"La calificación en letra es: {letra}");
    }
}
