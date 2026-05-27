using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SistemaNotas.Servicios;
using SistemaNotas.Modelo;

namespace InterfazGrafica
{
    public class VentanaPrincipallogin : Form
    {
        // Botones
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnSalir;

        // Cajas de texto
        private TextBox txtUsuario;
        private TextBox txtPassword;

        // Colores del tema
        private readonly Color colorPrimario = Color.FromArgb(37, 99, 235);      // Azul profesional
        private readonly Color colorPrimarioHover = Color.FromArgb(29, 78, 216);
        private readonly Color colorFondo = Color.FromArgb(248, 250, 252);
        private readonly Color colorPanel = Color.White;
        private readonly Color colorTexto = Color.FromArgb(30, 41, 59);
        private readonly Color colorTextoSecundario = Color.FromArgb(100, 116, 139);
        private readonly Color colorBorde = Color.FromArgb(226, 232, 240);
        private readonly Color colorPeligro = Color.FromArgb(239, 68, 68);
        private readonly Color colorSecundario = Color.FromArgb(100, 116, 139);

        // Constructor
        public VentanaPrincipallogin()
        {
            // Configuración ventana
            this.Text = "Sistema de Notas Académicas";
            this.Size = new Size(480, 580);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = colorFondo;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Font = new Font("Segoe UI", 10);

            // Panel central con sombra simulada
            Panel panelCentral = new Panel();
            panelCentral.Size = new Size(380, 460);
            panelCentral.Location = new Point(50, 50);
            panelCentral.BackColor = colorPanel;
            panelCentral.Paint += (s, e) =>
            {
                var rect = new Rectangle(0, 0, panelCentral.Width - 1, panelCentral.Height - 1);
                using (var pen = new Pen(colorBorde, 1))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };

            // Icono / Avatar circular
            Panel panelIcono = new Panel();
            panelIcono.Size = new Size(70, 70);
            panelIcono.Location = new Point(155, 30);
            panelIcono.BackColor = Color.Transparent;
            panelIcono.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(colorPrimario))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, 68, 68);
                }
                // Icono de usuario simplificado
                using (var pen = new Pen(Color.White, 2.5f))
                {
                    e.Graphics.DrawEllipse(pen, 24, 15, 20, 20);
                    e.Graphics.DrawArc(pen, 14, 38, 40, 30, 180, 180);
                }
            };

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Iniciar Sesión";
            lblTitulo.Location = new Point(0, 115);
            lblTitulo.Size = new Size(380, 35);
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = colorTexto;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Subtítulo
            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "Sistema de Notas Académicas";
            lblSubtitulo.Location = new Point(0, 150);
            lblSubtitulo.Size = new Size(380, 25);
            lblSubtitulo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitulo.ForeColor = colorTextoSecundario;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Label usuario
            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuario";
            lblUsuario.Location = new Point(40, 200);
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            lblUsuario.ForeColor = colorTexto;

            // TextBox usuario
            txtUsuario = new TextBox();
            txtUsuario.Location = new Point(40, 225);
            txtUsuario.Size = new Size(300, 35);
            txtUsuario.Font = new Font("Segoe UI", 11);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.BackColor = Color.FromArgb(249, 250, 251);

            // Label contraseña
            Label lblPassword = new Label();
            lblPassword.Text = "Contraseña";
            lblPassword.Location = new Point(40, 275);
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            lblPassword.ForeColor = colorTexto;

            // TextBox contraseña
            txtPassword = new TextBox();
            txtPassword.Location = new Point(40, 300);
            txtPassword.Size = new Size(300, 35);
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.PasswordChar = '●';
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.FromArgb(249, 250, 251);

            // Botón ingresar (principal)
            btnIngresar = new Button();
            btnIngresar.Text = "Ingresar";
            btnIngresar.Location = new Point(40, 360);
            btnIngresar.Size = new Size(300, 42);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.BackColor = colorPrimario;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Click += IngresarSistema;
            btnIngresar.MouseEnter += (s, e) => btnIngresar.BackColor = colorPrimarioHover;
            btnIngresar.MouseLeave += (s, e) => btnIngresar.BackColor = colorPrimario;

            // Botón limpiar (secundario)
            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.Location = new Point(40, 410);
            btnLimpiar.Size = new Size(145, 36);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderColor = colorBorde;
            btnLimpiar.FlatAppearance.BorderSize = 1;
            btnLimpiar.BackColor = colorPanel;
            btnLimpiar.ForeColor = colorSecundario;
            btnLimpiar.Font = new Font("Segoe UI", 9.5f);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Click += LimpiarCampos;
            btnLimpiar.MouseEnter += (s, e) => btnLimpiar.BackColor = Color.FromArgb(248, 250, 252);
            btnLimpiar.MouseLeave += (s, e) => btnLimpiar.BackColor = colorPanel;

            // Botón salir (peligro)
            btnSalir = new Button();
            btnSalir.Text = "Salir";
            btnSalir.Location = new Point(195, 410);
            btnSalir.Size = new Size(145, 36);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = colorPeligro;
            btnSalir.FlatAppearance.BorderSize = 1;
            btnSalir.BackColor = colorPanel;
            btnSalir.ForeColor = colorPeligro;
            btnSalir.Font = new Font("Segoe UI", 9.5f);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Click += SalirPrograma;
            btnSalir.MouseEnter += (s, e) => { btnSalir.BackColor = colorPeligro; btnSalir.ForeColor = Color.White; };
            btnSalir.MouseLeave += (s, e) => { btnSalir.BackColor = colorPanel; btnSalir.ForeColor = colorPeligro; };

            // Agregar controles al panel
            panelCentral.Controls.Add(panelIcono);
            panelCentral.Controls.Add(lblTitulo);
            panelCentral.Controls.Add(lblSubtitulo);
            panelCentral.Controls.Add(lblUsuario);
            panelCentral.Controls.Add(txtUsuario);
            panelCentral.Controls.Add(lblPassword);
            panelCentral.Controls.Add(txtPassword);
            panelCentral.Controls.Add(btnIngresar);
            panelCentral.Controls.Add(btnLimpiar);
            panelCentral.Controls.Add(btnSalir);

            // Agregar panel a la ventana
            this.Controls.Add(panelCentral);
        }

        // Evento ingresar
        private void IngresarSistema(object? sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor ingrese correo y contraseña.", 
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar login con el JSON
            LoginServicio servicio = new LoginServicio();
            Persona usuario = servicio.Login(correo, password);

            if (usuario != null)
            {
                this.Hide(); // Ocultar ventana de login

                if (usuario.Rol.ToLower() == "estudiante")
                {
                    // Leer grado del JSON (es atributo solo de estudiantes)
                    LoginServicio servicioGrado = new LoginServicio();
                    string grado = servicioGrado.ObtenerGrado(usuario.ID);

                    VentanaEstudiante ventana = new VentanaEstudiante(usuario.Nombre, usuario.ID, grado);
                    ventana.FormClosed += (s, args) => this.Close();
                    ventana.Show();
                }
                else if (usuario.Rol.ToLower() == "docente")
                {
                    VentanaProfesor ventana = new VentanaProfesor(usuario.Nombre);
                    ventana.FormClosed += (s, args) => this.Close();
                    ventana.Show();
                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", 
                    "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento limpiar
        private void LimpiarCampos(object? sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        // Evento salir
        private void SalirPrograma(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
