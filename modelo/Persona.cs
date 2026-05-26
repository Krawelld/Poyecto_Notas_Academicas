using SistemaNotas.Utilidades;

namespace SistemaNotas.Modelo
{    
    public abstract class Persona
    {
        // ATRIBUTOS PRIVADOS
        private int id;
        private int edad;
        private string nombre;
        private string documento;
        private string correo;



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

        // CONSTRUCTOR
        public Persona(int id, int edad, string nombre, string documento, string correo)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.documento = documento;
            this.correo = correo;
        }

        // MÉTODO PÚBLICO
        public virtual string MostrarInformacion()
        {
            return $"ID: {id}\n" +
                $"Nombre: {nombre}\n" +
                $"Documento: {documento}\n" +
                $"Correo: {correo}" +
                $"Edad: {edad}";
               
        }
    }
}