using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 7
// Escribe un programa que solicita al usuario un número que represente un día de la semana (1 para lunes, 2 para martes, etc.)
// y muestra el nombre completo del día correspondiente utilizando la sentencia switch.
// Pasos:
// 1. Pedir al usuario un número entre 1 y 7.
// 2. Validar que la entrada sea un número entero dentro del rango permitido.
// 3. Usar una sentencia switch para determinar el día de la semana correspondiente.
// 4. Mostrar el nombre del día según el número ingresado.

class Program
{
    static void Main()
    {
        int dia;

        // Solicita al usuario que ingrese un número del 1 al 7
        Console.Write("Ingrese un número del 1 al 7 para conocer el día de la semana: ");
        while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 7)
        {
            Console.Write("Entrada inválida. Ingrese un número entre 1 y 7: ");
        }

        // Determina el día de la semana utilizando switch
        string nombreDia;
        switch (dia)
        {
            case 1:
                nombreDia = "Lunes";
                break;
            case 2:
                nombreDia = "Martes";
                break;
            case 3:
                nombreDia = "Miércoles";
                break;
            case 4:
                nombreDia = "Jueves";
                break;
            case 5:
                nombreDia = "Viernes";
                break;
            case 6:
                nombreDia = "Sábado";
                break;
            case 7:
                nombreDia = "Domingo";
                break;
            default:
                nombreDia = "Desconocido";
                break;
        }

        // Muestra el nombre del día correspondiente
        Console.WriteLine($"El día corresponde a: {nombreDia}");
    }
}
