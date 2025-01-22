using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Clase Persona
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string DNI { get; set; }

    public Persona(string nombre, int edad, string dni)
    {
        Nombre = nombre;
        Edad = edad;
        DNI = dni;
    }
}

// 2. Clase Punto (Plano Cartesiano)
class Punto
{
    public double X { get; set; }
    public double Y { get; set; }

    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }
}

// 3. Clase Círculo
class Circulo
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radio { get; set; }

    public Circulo(double x, double y, double radio)
    {
        X = x;
        Y = y;
        Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

// 4. Segunda clase Persona con más atributos y método de impresión
class PersonaDetallada
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }

    public PersonaDetallada(string nombre, string apellido, int edad, string genero)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Genero = genero;
    }

    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}, Género: {Genero}");
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo de uso de las clases
        Persona persona1 = new Persona("Juan", 30, "12345678X");
        Console.WriteLine($"Persona: {persona1.Nombre}, Edad: {persona1.Edad}, DNI: {persona1.DNI}");

        Punto punto1 = new Punto(5, 10);
        Console.WriteLine($"Punto en el plano: ({punto1.X}, {punto1.Y})");

        Circulo circulo1 = new Circulo(3, 4, 10);
        Console.WriteLine($"Área del círculo: {circulo1.CalcularArea()}");

        PersonaDetallada personaDetallada1 = new PersonaDetallada("Ana", "Gómez", 25, "Femenino");
        personaDetallada1.ImprimirInformacion();
    }
}
