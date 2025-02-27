using System;
using System.Windows.Forms;

namespace GestionCalificaciones
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Asegurarse de que aquí se llame 'Form1'
        }
    }
}
