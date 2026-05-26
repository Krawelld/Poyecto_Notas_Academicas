namespace SistemaNotas.Modelo
{
    public class Profesor : Persona
    {
        // ATRIBUTOS PRIVADOS
        private string especialidad;
        private double salario;

        // PROPIEDADES PÚBLICAS
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
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

        // CONSTRUCTOR
        public Profesor(
            int ,
            int edad,
            string nombre,
            string documento,
            string correo,
            string especialidad,
            double salario
        ) : base(id, edad, nombre, documento, correo)
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