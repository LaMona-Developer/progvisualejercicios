using System;
using System.Windows.Forms;

namespace GestionCalificaciones
{
    public partial class Form1 : Form
    {
        private GestionAlumnos gestion; // Instancia de la clase GestionAlumnos

        public Form1()
        {
            InitializeComponent(); // Carga el diseño del formulario
            gestion = new GestionAlumnos(); // Inicializa la gestión de alumnos
            ActualizarGrid(); // Carga los datos en el DataGridView
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNota.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertimos los valores ingresados correctamente
            if (!int.TryParse(txtDNI.Text, out int dni) || !double.TryParse(txtNota.Text, out double nota))
            {
                MessageBox.Show("DNI y Nota deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creamos un nuevo alumno y lo agregamos a la gestión
            Alumno nuevoAlumno = new Alumno(dni, txtNombre.Text, txtApellido.Text, nota);
            gestion.AgregarAlumno(nuevoAlumno);
            ActualizarGrid(); // Actualizamos el DataGridView
            LimpiarCampos(); // Limpiamos los campos de texto
        }

        private void ActualizarGrid()
        {
            dgvAlumnos.DataSource = null; // Resetear la fuente de datos
            dgvAlumnos.DataSource = gestion.ObtenerLista(); // Asignar la nueva lista de alumnos
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNota.Clear();
        }
    }
}

