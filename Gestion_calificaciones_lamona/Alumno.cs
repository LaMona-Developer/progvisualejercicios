namespace GestionCalificaciones
{
    // Clase Alumno que hereda de Persona y agrega propiedades de nota y calificación
    public class Alumno : Persona
    {
        public double Nota { get; set; }
        public string Calificacion { get; set; }

        // Constructor para inicializar un alumno
        public Alumno(string dni, string nombre, string apellido, double nota)
            : base(dni, nombre, apellido)
        {
            Nota = nota;
            Calificacion = CalcularCalificacion(nota);
        }

        // Método para calcular la calificación en base a la nota
        private string CalcularCalificacion(double nota)
        {
            if (nota < 5) return "SS"; // Suspenso
            if (nota < 7) return "AP"; // Aprobado
            if (nota < 9) return "NT"; // Notable
            return "SB"; // Sobresaliente
        }

        // Método para actualizar la nota y recalcular la calificación
        public void ActualizarNota(double nuevaNota)
        {
            Nota = nuevaNota;
            Calificacion = CalcularCalificacion(nuevaNota);
        }
    }
}
