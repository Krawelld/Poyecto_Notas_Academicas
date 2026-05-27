using SistemaNotas.Utilidades;

namespace SistemaNotas.Modelo
{    
    public class Persona
    {
        // ATRIBUTOS PRIVADOS
        private int id;
        private int edad;
        private string nombre = string.Empty;
        private string documento = string.Empty;
        private string correo = string.Empty;
        private string rol = string.Empty;
        private string password = string.Empty;



        // PROPIEDADES PÚBLICAS
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = Normalizador.NormalizarNombre(value); }
        }

        public string Documento
        {
            get { return documento; }
            set 
            {
                if(value.Length >= 7 && value.Length <= 10)
                {
                    documento = Normalizador.NormalizarDocumento(value);
                }
                else
                {
                    Console.WriteLine("El documento debe tener entre 7 y 10 digitos");
                }
            }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = Normalizador.NormalizarCorreo(value); }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // CONSTRUCTOR VACÍO (necesario para deserializar JSON)
        public Persona() { }

        // CONSTRUCTOR CON PARÁMETROS
        public Persona(int id, int edad, string nombre, string documento, string correo, string rol, string password)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.documento = documento;
            this.correo = correo;
            this.rol = rol;
            this.password = password;
        }

        // MÉTODO PÚBLICO
        public virtual string MostrarInformacion()
        {
            return $"ID: {id}\n" +
                $"Nombre: {nombre}\n" +
                $"Documento: {documento}\n" +
                $"Correo: {correo}\n" +
                $"Edad: {edad}\n" +
                $"Rol: {rol}";
        }
    }
}