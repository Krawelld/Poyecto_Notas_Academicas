namespace SistemaNotas.Modelo
{
    public class Estudiante : Persona
    {
        // ATRIBUTOS PRIVADOS
        private double promedio;
        private string grado = string.Empty;
        private Materia materia = null!;
        private List<Nota> notas = new List<Nota>();

        // PROPIEDADES PÚBLICAS
        public double Promedio
        {
            get { return promedio; }
            set 
            { 
                if(value >= 0)
                {
                    promedio = value;
                }
                else
                {
                    Console.WriteLine("El promedio debe ser positivo");
                }
            }
        }
        public string Grado
        {
            get { return grado; }
            set { grado = value; }
        }

        public Materia Materia
        {
            get {return materia; }
            set {materia = value; }
        }

        //Lista para guardar notas
        public List<Nota> Notas
        {
            get { return notas; }
        }

        // CONSTRUCTOR VACÍO (necesario para deserializar JSON)
        public Estudiante() 
        { 
            notas = new List<Nota>(); 
        }

        // CONSTRUCTOR CON PARÁMETROS
        public Estudiante(
            int id,
            int edad,
            string nombre,
            string documento,
            string correo,
            string rol,
            string password,
            string grado,
            double promedio
        ) : base(id, edad, nombre, documento, correo, rol, password)
        {
            this.promedio = promedio;
            this.grado = grado;
            notas = new List<Nota>();
        }

         // VER NOTAS
        public string VerNotas()
        {
            string resultado = "NOTAS DEL ESTUDIANTE\n\n";

            foreach(Nota nota in notas)
            {
                resultado += nota.MostrarNota() + "\n\n";
            }

            return resultado;
        }

        // VER MATERIAS
        public string VerMaterias()
        {
            string resultado = "MATERIAS DEL ESTUDIANTE\n\n";

            foreach(Nota nota in notas)
            {
                resultado +=
                    nota.Materia.Nombre + "\n";
            }

            return resultado;
        }

        // MÉTODO OVERRIDE
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() +
                   $"\nPromedio: {promedio}" +
                   $"\nGrado: {grado}";
        }

        
    }
}