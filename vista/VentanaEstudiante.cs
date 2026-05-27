using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SistemaNotas.Servicios;
using SistemaNotas.Modelo;

namespace InterfazGrafica
{
    public class VentanaEstudiante : Form
    {
        private Label lblBienvenida;

        private Button btnNotas;
        private Button btnPromedio;
        private Button btnGrado;
        private Button btnCerrarSesion;

        // ID del estudiante para consultar sus notas
        private int estudianteID;
        private string gradoEstudiante;

        // Colores del tema
        private readonly Color colorPrimario = Color.FromArgb(37, 99, 235);
        private readonly Color colorFondo = Color.FromArgb(248, 250, 252);
        private readonly Color colorPanel = Color.White;
        private readonly Color colorTexto = Color.FromArgb(30, 41, 59);
        private readonly Color colorTextoSecundario = Color.FromArgb(100, 116, 139);
        private readonly Color colorBorde = Color.FromArgb(226, 232, 240);
        private readonly Color colorPeligro = Color.FromArgb(239, 68, 68);
        private readonly Color colorVerde = Color.FromArgb(34, 197, 94);
        private readonly Color colorNaranja = Color.FromArgb(249, 115, 22);

        public VentanaEstudiante(string nombreUsuario, int id, string grado)
        {
            this.estudianteID = id;
            this.gradoEstudiante = grado;
            // Configuración ventana
            this.Text = "Panel Estudiante - Sistema Académico";
            this.Size = new Size(780, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = colorFondo;
            this.Font = new Font("Segoe UI", 10);
            this.MinimumSize = new Size(780, 520);

            // ===== BARRA SUPERIOR (Header) =====
            Panel panelHeader = new Panel();
            panelHeader.Size = new Size(780, 70);
            panelHeader.Location = new Point(0, 0);
            panelHeader.BackColor = colorPrimario;
            panelHeader.Dock = DockStyle.Top;

            Label lblTitulo = new Label();
            lblTitulo.Text = "📚  Sistema Académico";
            lblTitulo.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.AutoSize = true;

            panelHeader.Controls.Add(lblTitulo);

            // ===== PANEL DE BIENVENIDA =====
            Panel panelBienvenida = new Panel();
            panelBienvenida.Size = new Size(710, 70);
            panelBienvenida.Location = new Point(25, 90);
            panelBienvenida.BackColor = colorPanel;
            panelBienvenida.Paint += (s, e) =>
            {
                var rect = new Rectangle(0, 0, panelBienvenida.Width - 1, panelBienvenida.Height - 1);
                using (var pen = new Pen(colorBorde, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
                // Línea de acento izquierda
                using (var brush = new SolidBrush(colorPrimario))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 4, panelBienvenida.Height);
                }
            };

            lblBienvenida = new Label();
            lblBienvenida.Text = "Bienvenido, " + nombreUsuario;
            lblBienvenida.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblBienvenida.ForeColor = colorTexto;
            lblBienvenida.Location = new Point(20, 12);
            lblBienvenida.AutoSize = true;

            Label lblRol = new Label();
            lblRol.Text = "Estudiante  •  Sesión activa";
            lblRol.Font = new Font("Segoe UI", 9.5f);
            lblRol.ForeColor = colorTextoSecundario;
            lblRol.Location = new Point(20, 40);
            lblRol.AutoSize = true;

            panelBienvenida.Controls.Add(lblBienvenida);
            panelBienvenida.Controls.Add(lblRol);

            // ===== GRID DE OPCIONES =====
            Label lblMenu = new Label();
            lblMenu.Text = "Menú Principal";
            lblMenu.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblMenu.ForeColor = colorTexto;
            lblMenu.Location = new Point(25, 180);
            lblMenu.AutoSize = true;

            // Botón notas
            btnNotas = CrearBotonMenu("📝", "Notas", "Consulta tus calificaciones", colorPrimario);
            btnNotas.Location = new Point(80, 215);
            btnNotas.Click += VerNotas;

            // Botón promedio
            btnPromedio = CrearBotonMenu("📊", "Promedio", "Promedio acumulado", colorVerde);
            btnPromedio.Location = new Point(300, 215);
            btnPromedio.Click += VerPromedio;

            // Botón grado
            btnGrado = CrearBotonMenu("🎓", "Grado", "Información de tu grado", colorNaranja);
            btnGrado.Location = new Point(520, 215);
            btnGrado.Click += VerGrado;

            // ===== BOTÓN CERRAR SESIÓN =====
            btnCerrarSesion = new Button();
            btnCerrarSesion.Text = "🚪  Cerrar Sesión";
            btnCerrarSesion.Size = new Size(180, 40);
            btnCerrarSesion.Location = new Point(555, 430);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FlatAppearance.BorderColor = colorPeligro;
            btnCerrarSesion.FlatAppearance.BorderSize = 1;
            btnCerrarSesion.BackColor = colorPanel;
            btnCerrarSesion.ForeColor = colorPeligro;
            btnCerrarSesion.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Click += CerrarSesion;
            btnCerrarSesion.MouseEnter += (s, e) => { btnCerrarSesion.BackColor = colorPeligro; btnCerrarSesion.ForeColor = Color.White; };
            btnCerrarSesion.MouseLeave += (s, e) => { btnCerrarSesion.BackColor = colorPanel; btnCerrarSesion.ForeColor = colorPeligro; };

            // ===== FOOTER =====
            Label lblFooter = new Label();
            lblFooter.Text = "© 2026 Sistema de Notas Académicas";
            lblFooter.Font = new Font("Segoe UI", 8.5f);
            lblFooter.ForeColor = colorTextoSecundario;
            lblFooter.Location = new Point(25, 440);
            lblFooter.AutoSize = true;

            // Agregar controles
            this.Controls.Add(panelHeader);
            this.Controls.Add(panelBienvenida);
            this.Controls.Add(lblMenu);
            this.Controls.Add(btnNotas);
            this.Controls.Add(btnPromedio);
            this.Controls.Add(btnGrado);
            this.Controls.Add(btnCerrarSesion);
            this.Controls.Add(lblFooter);
        }

        /// <summary>
        /// Crea un botón estilo tarjeta para el menú principal.
        /// </summary>
        private Button CrearBotonMenu(string icono, string titulo, string descripcion, Color colorAccento)
        {
            Button btn = new Button();
            btn.Size = new Size(160, 180);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = colorBorde;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = colorPanel;
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Font = new Font("Segoe UI", 9.5f);
            btn.ForeColor = colorTexto;
            btn.Text = icono + "\n\n" + titulo + "\n" + descripcion;

            btn.Paint += (s, e) =>
            {
                // Línea de color superior
                using (var brush = new SolidBrush(colorAccento))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, btn.Width, 4);
                }
            };

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(248, 250, 252);
                btn.FlatAppearance.BorderColor = colorAccento;
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = colorPanel;
                btn.FlatAppearance.BorderColor = colorBorde;
            };

            return btn;
        }

        // Evento ver grado
        private void VerGrado(object? sender, EventArgs e)
        {
            MessageBox.Show($"Tu grado actual:\n\n{gradoEstudiante}",
                "Información de Grado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento ver promedio
        private void VerPromedio(object? sender, EventArgs e)
        {
            NotasServicio servicio = new NotasServicio();
            Nota[] notas = servicio.ObtenerNotasPorEstudiante(estudianteID);

            if (notas.Length == 0)
            {
                MessageBox.Show("No tienes notas registradas.",
                    "Sin notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Calcular promedio
            double suma = 0;
            foreach (Nota nota in notas)
            {
                suma += nota.ValorNota;
            }
            double promedio = suma / notas.Length;

            MessageBox.Show($"Tu promedio es: {promedio:F2}",
                "Promedio Académico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento ver notas
        private void VerNotas(object? sender, EventArgs e)
        {
            NotasServicio servicio = new NotasServicio();
            Nota[] notas = servicio.ObtenerNotasPorEstudiante(estudianteID);

            if (notas.Length == 0)
            {
                MessageBox.Show("No tienes notas registradas.",
                    "Sin notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string resultado = "MIS NOTAS\n\n";

            foreach (Nota nota in notas)
            {
                resultado += $"Materia: {nota.Materia.Nombre}\n";
                resultado += $"Periodo: {nota.Periodo}\n";
                resultado += $"Nota: {nota.ValorNota}\n";
                resultado += "─────────────────\n";
            }

            MessageBox.Show(resultado, "Notas del Estudiante",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CerrarSesion(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
