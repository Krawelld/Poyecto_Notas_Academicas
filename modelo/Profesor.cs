using SistemaNotas.Utilidades;

namespace SistemaNotas.Modelo
{
    public class Profesor : Persona
    {
        // ATRIBUTOS PRIVADOS
        private string especialidad = string.Empty;
        private double salario;

        // PROPIEDADES PÚBLICAS
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = Normalizador.NormalizarTexto(value); }
        }

        public double Salario
        {
            get { return salario; }
            set { 
                
                if(value >= 0)
                {
                    salario = value;
                }
                else
                {
                    Console.WriteLine("El salario debe ser positivo");
                }
            }
        }

        // CONSTRUCTOR VACÍO (necesario para deserializar JSON)
        public Profesor() { }

        // CONSTRUCTOR CON PARÁMETROS
        public Profesor(
            int id,
            int edad,
            string nombre,
            string documento,
            string correo,
            string rol,
            string password,
            string especialidad,
            double salario
        ) : base(id, edad, nombre, documento, correo, rol, password)
        {
            this.especialidad = especialidad;
            this.salario = salario;
        }


        //METODOS 

        //AGREGAR NOTA
        public void AgregarNota(
            Estudiante estudiante,
            Nota nota
        )
        {
            estudiante.Notas.Add(nota);
        }

        // MODIFICAR NOTA
        public void ModificarNota(
            Nota nota,
            double nuevaNota
        )
        {
            if(nuevaNota >= 0 && nuevaNota <= 5)
            {
                nota.ValorNota = nuevaNota;
            }
            else
            {
                Console.WriteLine("Nota inválida");
            }
        }
        // MÉTODO OVERRIDE
        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() +
                   $"\nEspecialidad: {especialidad}" +
                   $"\nSalario: ${salario}";
        }
    }
}