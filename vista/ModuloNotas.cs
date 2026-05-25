using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public class ModuloNotas : Form
    {
        // Controles
        private DataGridView dgvNotas;
        private Button btnVolver;

        public ModuloNotas(string nombreEstudiante)
        {
            // Configuración ventana
            this.Text = "Módulo de Notas";
            this.Size = new Size(700, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 250, 252);
            this.Font = new Font("Segoe UI", 10);

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "📝  Notas - " + nombreEstudiante;
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.AutoSize = true;

            // Tabla de notas
            dgvNotas = new DataGridView();
            dgvNotas.Location = new Point(25, 70);
            dgvNotas.Size = new Size(630, 270);
            dgvNotas.BackgroundColor = Color.White;
            dgvNotas.BorderStyle = BorderStyle.None;
            dgvNotas.GridColor = Color.FromArgb(226, 232, 240);
            dgvNotas.RowHeadersVisible = false;
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.ReadOnly = true;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotas.Font = new Font("Segoe UI", 9.5f);
            dgvNotas.ColumnHeadersHeight = 38;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNotas.EnableHeadersVisualStyles = false;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvNotas.RowTemplate.Height = 35;

            // Columnas
            dgvNotas.Columns.Add("Materia", "Materia");
            dgvNotas.Columns.Add("Nota1", "Nota 1");
            dgvNotas.Columns.Add("Nota2", "Nota 2");
            dgvNotas.Columns.Add("Nota3", "Nota 3");
            dgvNotas.Columns.Add("Definitiva", "Definitiva");
            dgvNotas.Columns.Add("Estado", "Estado");

            // Botón volver
            btnVolver = new Button();
            btnVolver.Text = "← Volver";
            btnVolver.Size = new Size(120, 38);
            btnVolver.Location = new Point(535, 360);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnVolver.BackColor = Color.White;
            btnVolver.ForeColor = Color.FromArgb(30, 41, 59);
            btnVolver.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Click += Volver;

            // Agregar controles
            this.Controls.Add(lblTitulo);
            this.Controls.Add(dgvNotas);
            this.Controls.Add(btnVolver);
        }

        private void Volver(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
