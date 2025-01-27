using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 8
// Crea un programa que reciba la calificación numérica de un estudiante y muestre la letra equivalente de la calificación (A, B, C, D, F)
// utilizando la sentencia switch.
// Pasos:
// 1. Pedir al usuario una calificación numérica entre 0 y 100.
// 2. Validar que la entrada sea un número entero dentro del rango permitido.
// 3. Usar una sentencia switch para determinar la calificación en letra.
// 4. Mostrar la calificación en letra según el rango correspondiente.

class Program
{
    static void Main()
    {
        int calificacion;

        // Solicita al usuario que ingrese una calificación entre 0 y 100
        Console.Write("Ingrese una calificación (0-100): ");
        while (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)
        {
            Console.Write("Entrada inválida. Ingrese una calificación válida entre 0 y 100: ");
        }

        // Determina la calificación en letra utilizando switch
        char letraCalificacion;
        switch (calificacion / 10)
        {
            case 10:
            case 9:
                letraCalificacion = 'A';
                break;
            case 8:
                letraCalificacion = 'B';
                break;
            case 7:
                letraCalificacion = 'C';
                break;
            case 6:
                letraCalificacion = 'D';
                break;
            default:
                letraCalificacion = 'F';
                break;
        }

        // Muestra la calificación en letra correspondiente
        Console.WriteLine($"La calificación en letra es: {letraCalificacion}");
    }
}
