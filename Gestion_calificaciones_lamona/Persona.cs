using System;

namespace GestionCalificaciones
{
    // Clase base que representa una persona con DNI, nombre y apellido
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructor para inicializar los datos de una persona
        public Persona(string dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}

