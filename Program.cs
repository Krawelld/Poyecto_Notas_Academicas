namespace InterfazGrafica;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
       
        Application.Run(new VentanaPrincipallogin());
        //Application.Run(new VentanaEstudiante("Alejo"));
        //Application.Run(new ModuloNotas("Alejo"));

        //---Interfaz Profesor--//
        //Application.Run(new VentanaProfesor("Carlos Pérez"));

    }
}