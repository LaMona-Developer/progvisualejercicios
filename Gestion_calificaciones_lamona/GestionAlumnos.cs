using System.Collections.Generic;

namespace GestionCalificaciones
{
    public class GestionAlumnos
    {
        private List<Alumno> listaAlumnos;

        public GestionAlumnos()
        {
            listaAlumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public List<Alumno> ObtenerLista()
        {
            return listaAlumnos;
        }
    }
}