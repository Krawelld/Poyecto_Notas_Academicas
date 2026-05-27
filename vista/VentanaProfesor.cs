using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SistemaNotas.Servicios;
using SistemaNotas.Modelo;

namespace InterfazGrafica
{
    public class VentanaProfesor : Form
    {
        // Botones
        private Button btnRegistrarNotas;
        private Button btnModificarNotas;
        private Button btnVerEstudiantes;
        private Button btnCerrarSesion;

        public VentanaProfesor(string nombreProfesor)
        {
            // Configuración ventana
            this.Text = "Panel Profesor - Sistema Académico";
            this.Size = new Size(650, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 250, 252);
            this.Font = new Font("Segoe UI", 10);

            // Header
            Panel panelHeader = new Panel();
            panelHeader.Size = new Size(650, 65);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.BackColor = Color.FromArgb(15, 118, 110); // Verde azulado profesional

            Label lblTitulo = new Label();
            lblTitulo.Text = "🎓  Panel del Profesor";
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 18);
            lblTitulo.AutoSize = true;

            panelHeader.Controls.Add(lblTitulo);

            // Bienvenida
            Label lblBienvenida = new Label();
            lblBienvenida.Text = "Bienvenido, " + nombreProfesor;
            lblBienvenida.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(30, 41, 59);
            lblBienvenida.Location = new Point(30, 85);
            lblBienvenida.AutoSize = true;

            Label lblRol = new Label();
            lblRol.Text = "Profesor  •  Sesión activa";
            lblRol.Font = new Font("Segoe UI", 9.5f);
            lblRol.ForeColor = Color.FromArgb(100, 116, 139);
            lblRol.Location = new Point(30, 112);
            lblRol.AutoSize = true;

            // Menú
            Label lblMenu = new Label();
            lblMenu.Text = "Opciones disponibles";
            lblMenu.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(30, 41, 59);
            lblMenu.Location = new Point(30, 155);
            lblMenu.AutoSize = true;

            // Botón Registrar Notas
            btnRegistrarNotas = new Button();
            btnRegistrarNotas.Text = "📝  Registrar Notas";
            btnRegistrarNotas.Size = new Size(270, 55);
            btnRegistrarNotas.Location = new Point(30, 195);
            btnRegistrarNotas.FlatStyle = FlatStyle.Flat;
            btnRegistrarNotas.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnRegistrarNotas.BackColor = Color.White;
            btnRegistrarNotas.ForeColor = Color.FromArgb(30, 41, 59);
            btnRegistrarNotas.Font = new Font("Segoe UI", 11);
            btnRegistrarNotas.Cursor = Cursors.Hand;
            btnRegistrarNotas.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarNotas.Padding = new Padding(15, 0, 0, 0);
            btnRegistrarNotas.Click += RegistrarNotas;

            // Botón Modificar Notas
            btnModificarNotas = new Button();
            btnModificarNotas.Text = "✏️  Modificar Notas";
            btnModificarNotas.Size = new Size(270, 55);
            btnModificarNotas.Location = new Point(320, 195);
            btnModificarNotas.FlatStyle = FlatStyle.Flat;
            btnModificarNotas.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnModificarNotas.BackColor = Color.White;
            btnModificarNotas.ForeColor = Color.FromArgb(30, 41, 59);
            btnModificarNotas.Font = new Font("Segoe UI", 11);
            btnModificarNotas.Cursor = Cursors.Hand;
            btnModificarNotas.TextAlign = ContentAlignment.MiddleLeft;
            btnModificarNotas.Padding = new Padding(15, 0, 0, 0);
            btnModificarNotas.Click += ModificarNotas;

            // Botón Ver Estudiantes
            btnVerEstudiantes = new Button();
            btnVerEstudiantes.Text = "👥  Ver Estudiantes";
            btnVerEstudiantes.Size = new Size(270, 55);
            btnVerEstudiantes.Location = new Point(30, 270);
            btnVerEstudiantes.FlatStyle = FlatStyle.Flat;
            btnVerEstudiantes.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnVerEstudiantes.BackColor = Color.White;
            btnVerEstudiantes.ForeColor = Color.FromArgb(30, 41, 59);
            btnVerEstudiantes.Font = new Font("Segoe UI", 11);
            btnVerEstudiantes.Cursor = Cursors.Hand;
            btnVerEstudiantes.TextAlign = ContentAlignment.MiddleLeft;
            btnVerEstudiantes.Padding = new Padding(15, 0, 0, 0);
            btnVerEstudiantes.Click += VerEstudiantes;

            // Botón Cerrar Sesión
            btnCerrarSesion = new Button();
            btnCerrarSesion.Text = "🚪  Cerrar Sesión";
            btnCerrarSesion.Size = new Size(160, 40);
            btnCerrarSesion.Location = new Point(440, 385);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.ForeColor = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Click += CerrarSesion;

            // Footer
            Label lblFooter = new Label();
            lblFooter.Text = "© 2026 Sistema de Notas Académicas";
            lblFooter.Font = new Font("Segoe UI", 8.5f);
            lblFooter.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooter.Location = new Point(30, 395);
            lblFooter.AutoSize = true;

            // Agregar controles
            this.Controls.Add(panelHeader);
            this.Controls.Add(lblBienvenida);
            this.Controls.Add(lblRol);
            this.Controls.Add(lblMenu);
            this.Controls.Add(btnRegistrarNotas);
            this.Controls.Add(btnModificarNotas);
            this.Controls.Add(btnVerEstudiantes);
            this.Controls.Add(btnCerrarSesion);
            this.Controls.Add(lblFooter);
        }

        private void RegistrarNotas(object? sender, EventArgs e)
        {
            ProfesorServicio servicio = new ProfesorServicio();
            Persona[] estudiantes = servicio.ObtenerEstudiantes();

            if (estudiantes.Length == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            // Seleccionar estudiante
            string[] nombres = new string[estudiantes.Length];
            for (int i = 0; i < estudiantes.Length; i++)
            {
                nombres[i] = estudiantes[i].ID + " - " + estudiantes[i].Nombre;
            }

            string seleccion = MostrarInputBox("Estudiantes:\n" + string.Join("\n", nombres) +
                "\n\nEscribe el ID del estudiante:", "Registrar Nota");

            if (string.IsNullOrEmpty(seleccion)) return;

            int estudianteID;
            if (!int.TryParse(seleccion, out estudianteID))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            // Pedir datos de la nota
            string materia = MostrarInputBox("Nombre de la materia:", "Materia");
            if (string.IsNullOrEmpty(materia)) return;

            string codigo = MostrarInputBox("Código de la materia (ej: MAT101):", "Código");
            if (string.IsNullOrEmpty(codigo)) return;

            string periodo = MostrarInputBox("Periodo (ej: 2025-1):", "Periodo");
            if (string.IsNullOrEmpty(periodo)) return;

            string valorTexto = MostrarInputBox("Valor de la nota (0 a 5):", "Nota");
            if (string.IsNullOrEmpty(valorTexto)) return;

            double valorNota;
            if (!double.TryParse(valorTexto, out valorNota) || valorNota < 0 || valorNota > 5)
            {
                MessageBox.Show("Nota inválida. Debe ser entre 0 y 5.");
                return;
            }

            // Guardar
            servicio.AgregarNota(estudianteID, periodo, valorNota, codigo, materia);
            MessageBox.Show("Nota registrada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModificarNotas(object? sender, EventArgs e)
        {
            ProfesorServicio servicio = new ProfesorServicio();
            Persona[] estudiantes = servicio.ObtenerEstudiantes();

            // Seleccionar estudiante
            string[] nombres = new string[estudiantes.Length];
            for (int i = 0; i < estudiantes.Length; i++)
            {
                nombres[i] = estudiantes[i].ID + " - " + estudiantes[i].Nombre;
            }

            string seleccion = MostrarInputBox("Estudiantes:\n" + string.Join("\n", nombres) +
                "\n\nEscribe el ID del estudiante:", "Modificar Nota");

            if (string.IsNullOrEmpty(seleccion)) return;

            int estudianteID;
            if (!int.TryParse(seleccion, out estudianteID))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            // Mostrar notas del estudiante
            Nota[] notas = servicio.ObtenerNotasPorEstudiante(estudianteID);

            if (notas.Length == 0)
            {
                MessageBox.Show("Este estudiante no tiene notas.");
                return;
            }

            string listaNotas = "";
            foreach (Nota nota in notas)
            {
                listaNotas += $"ID: {nota.IdNota} | {nota.Materia.Nombre} | Nota: {nota.ValorNota}\n";
            }

            string idNotaTexto = MostrarInputBox("Notas del estudiante:\n" + listaNotas +
                "\nEscribe el ID de la nota a modificar:", "Seleccionar Nota");

            if (string.IsNullOrEmpty(idNotaTexto)) return;

            int idNota;
            if (!int.TryParse(idNotaTexto, out idNota))
            {
                MessageBox.Show("ID de nota inválido.");
                return;
            }

            string nuevoValorTexto = MostrarInputBox("Nuevo valor de la nota (0 a 5):", "Nueva Nota");
            if (string.IsNullOrEmpty(nuevoValorTexto)) return;

            double nuevoValor;
            if (!double.TryParse(nuevoValorTexto, out nuevoValor) || nuevoValor < 0 || nuevoValor > 5)
            {
                MessageBox.Show("Nota inválida. Debe ser entre 0 y 5.");
                return;
            }

            servicio.ModificarNota(idNota, nuevoValor);
            MessageBox.Show("Nota modificada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VerEstudiantes(object? sender, EventArgs e)
        {
            ProfesorServicio servicio = new ProfesorServicio();
            Persona[] estudiantes = servicio.ObtenerEstudiantes();

            if (estudiantes.Length == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            string resultado = "LISTA DE ESTUDIANTES\n\n";

            foreach (Persona est in estudiantes)
            {
                resultado += $"ID: {est.ID}\n";
                resultado += $"Nombre: {est.Nombre}\n";
                resultado += $"Correo: {est.Correo}\n";
                resultado += $"Documento: {est.Documento}\n";
                resultado += "─────────────────\n";
            }

            MessageBox.Show(resultado, "Estudiantes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // InputBox sencillo (Windows Forms no tiene uno nativo)
        private string MostrarInputBox(string mensaje, string titulo)
        {
            Form inputForm = new Form();
            inputForm.Text = titulo;
            inputForm.Size = new Size(400, 250);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;

            Label lbl = new Label();
            lbl.Text = mensaje;
            lbl.Location = new Point(15, 15);
            lbl.Size = new Size(360, 130);

            TextBox txt = new TextBox();
            txt.Location = new Point(15, 150);
            txt.Size = new Size(350, 25);

            Button btnOk = new Button();
            btnOk.Text = "Aceptar";
            btnOk.Location = new Point(210, 180);
            btnOk.DialogResult = DialogResult.OK;

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(295, 180);
            btnCancelar.DialogResult = DialogResult.Cancel;

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOk);
            inputForm.Controls.Add(btnCancelar);
            inputForm.AcceptButton = btnOk;
            inputForm.CancelButton = btnCancelar;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return txt.Text.Trim();
            }

            return "";
        }

        private void CerrarSesion(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
