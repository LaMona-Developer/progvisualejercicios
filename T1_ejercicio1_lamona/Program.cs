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
        // 1. Imprimir los números pares sin usar if
        Console.WriteLine("Números pares del 1 al 100 (sin if):");
        for (int i = 2; i <= 100; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2. Imprimir los números pares con if
        Console.WriteLine("Números pares del 1 al 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine("\n");

        // 3. Imprimir FizzBuzz
        Console.WriteLine("FizzBuzz del 1 al 50:");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
        Console.WriteLine();

        // 4. Imprimir números del 1 al 10 con while
        Console.WriteLine("Números del 1 al 10 con while:");
        int j = 1;
        while (j <= 10)
        {
            Console.Write(j + " ");
            j++;
        }
        Console.WriteLine("\n");

        // 5. Suma de los primeros 100 números enteros con while
        Console.WriteLine("Suma de los primeros 100 números enteros:");
        int k = 1, suma = 0;
        while (k <= 100)
        {
            suma += k;
            k++;
        }
        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine();

        // 6. Imprimir números pares con while
        Console.WriteLine("Números pares del 1 al 100 con while:");
        int m = 2;
        while (m <= 100)
        {
            Console.Write(m + " ");
            m += 2;
        }
        Console.WriteLine("\n");
    }
}
