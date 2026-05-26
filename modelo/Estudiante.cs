namespace SistemaNotas.Modelo
{
    public class Estudiante : Persona
    {
        // ATRIBUTOS PRIVADOS
        private double promedio;
        private string grado;
        private List<Nota> notas;

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

        //LISTA PARA GUARDAR NOTAS
        public List<Nota> Notas
        {
            get { return notas; }
        }

        // CONSTRUCTOR
        public Estudiante(
            int id,
            int edad,
            string nombre,
            string documento,
            string correo,
            string grado,
            double promedio
        ) : base(id, edad, nombre, documento, correo)
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

        public double CalcularPromedio()
        {
            // VALIDAR SI HAY NOTAS
            if(notas.Count == 0)
            {
                return 0;
            }

            double suma = 0;

            // RECORRER LAS NOTAS
            foreach(Nota nota in notas)
            {
                suma += nota.ValorNota;
            }

            // CALCULAR PROMEDIO
            return suma / notas.Count;
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