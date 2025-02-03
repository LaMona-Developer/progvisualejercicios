using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

// Actuación en clase 2 ejercicio 2
// Crea un programa que sume una serie de números enteros.
// Utiliza una variable global para almacenar la suma total y una función para agregar números a esta suma.
// Pasos:
// 1. Declarar una variable global llamada sumaTotal de tipo int.
// 2. Definir una función llamada AgregarNumero que reciba un número entero y lo sume a sumaTotal.
// 3. En el método Main, solicitar al usuario que ingrese varios números.
// 4. Llamar a la función AgregarNumero para cada número ingresado.
// 5. Mostrar la suma total al final.

class Program
{
    // Variable global para almacenar la suma total
    static int sumaTotal = 0;

    static void Main()
    {
        string entrada;
        int numero;

        Console.WriteLine("Ingrese números enteros para sumar. Escriba 'fin' para terminar.");

        // Bucle para recibir números hasta que el usuario ingrese "fin"
        do
        {
            Console.Write("Ingrese un número: ");
            entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                AgregarNumero(numero);
            }
            else if (entrada.ToLower() != "fin")
            {
                Console.WriteLine("Entrada inválida. Ingrese un número entero o 'fin' para salir.");
            }

        } while (entrada.ToLower() != "fin");

        // Mostrar la suma total
        Console.WriteLine($"La suma total de los números ingresados es: {sumaTotal}");
    }

    // Función para agregar un número a la suma total
    static void AgregarNumero(int numero)
    {
        sumaTotal += numero;
    }
}
