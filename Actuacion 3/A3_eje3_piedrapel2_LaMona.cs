using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 3 ejercicio 3
// Crea un programa en C# que simule el juego de Piedra, Papel o Tijera.
// Pasos:
// 1. Solicitar al usuario que elija entre Piedra, Papel o Tijera.
// 2. Generar una elección aleatoria para la computadora.
// 3. Comparar ambas elecciones y determinar el ganador.
// 4. Mostrar el resultado al usuario.
// 5. Permitir jugar varias rondas hasta que el usuario decida salir.

class Program
{
    static void Main()
    {
        string[] opciones = { "Piedra", "Papel", "Tijera" };
        Random random = new Random();
        string eleccionUsuario;

        do
        {
            Console.Write("Elige Piedra, Papel o Tijera (o escribe 'salir' para terminar): ");
            eleccionUsuario = Console.ReadLine();

            if (eleccionUsuario.ToLower() == "salir") break;

            if (!Array.Exists(opciones, opcion => opcion.Equals(eleccionUsuario, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Entrada no válida. Intenta de nuevo.");
                continue;
            }

            string eleccionComputadora = opciones[random.Next(3)];
            Console.WriteLine($"La computadora eligió: {eleccionComputadora}");

            if (eleccionUsuario.Equals(eleccionComputadora, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Empate!");
            else if ((eleccionUsuario == "Piedra" && eleccionComputadora == "Tijera") ||
                     (eleccionUsuario == "Papel" && eleccionComputadora == "Piedra") ||
                     (eleccionUsuario == "Tijera" && eleccionComputadora == "Papel"))
                Console.WriteLine("¡Ganaste!");
            else
                Console.WriteLine("Perdiste. Intenta de nuevo!");

        } while (true);

        Console.WriteLine("Gracias por jugar. Hasta la próxima!");
    }
}
