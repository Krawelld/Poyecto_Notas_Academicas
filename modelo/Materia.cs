using SistemaNotas.Utilidades;

namespace SistemaNotas.Modelo
{
    public class Materia
    {
        // ATRIBUTOS PRIVADOS
        private string codigo;
        private string nombre;

        // PROPIEDADES PÚBLICAS
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = Normalizador.NormalizarNombre(value); }
        }

        // CONSTRUCTOR
        public Materia(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        // MÉTODO
        public string MostrarMateria()
        {
            return $"Código: {codigo}\n" +
                   $"Materia: {nombre}";
        }
    }
}