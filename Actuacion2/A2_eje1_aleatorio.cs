using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
// 
// Programa que genera un número aleatorio entre 1 y 100 y permite al usuario adivinarlo.
// El programa proporciona pistas si el número ingresado es mayor o menor que el número secreto.
///ejercici1 = realizar un menu de opciones 
/* pasos que vamos a utilizar son:
 * paso 1= generar un numero 
 * paso 2= pedir que igrese un numero al usuario
 * paso 3= guardar el numero por el usuario
 * paso 4= conparat si el numero es = al numero del usuario 
 * paso 5= si el numero es igual ahi queda 
 * paso 6= comparar si el numero es mayor o menor que  el numero areatoriamente 
 * paso 7= si es menor imprimir por consola debe ser un numero mayor 
 * paso 8= sio el es mayor debe imprimir  un numero menor 
 *// paso 9 = se repite del paso 4 hasta que que el usuario cumpla 
class Program
{
    static void Main()
    {
        // Genera un número aleatorio entre 1 y 100
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int intento;

        Console.WriteLine("Adivina el número entre 1 y 100");

        // Solicita al usuario que ingrese un número hasta que el valor sea válido
        do
        {
            Console.Write("Ingrese su intento: ");
        } while (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100);

        // Bucle para continuar pidiendo intentos hasta que el usuario acierte
        while (intento != numeroAleatorio)
        {
            if (intento < numeroAleatorio)
                Console.WriteLine("El número es mayor."); // Pista si el número ingresado es menor
            else
                Console.WriteLine("El número es menor."); // Pista si el número ingresado es mayor

            // Solicita un nuevo intento hasta que el valor ingresado sea válido
            do
            {
                Console.Write("Intente de nuevo: ");
            } while (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100);
        }

        // Mensaje de éxito cuando el usuario adivina el número
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
    }
}
