using SistemaNotas.Utilidades;

namespace SistemaNotas.Modelo
{
    public class Materia
    {
        // ATRIBUTOS PRIVADOS
        private string codigo = string.Empty;
        private string nombre = string.Empty;

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

        // CONSTRUCTOR VACÍO (necesario para deserializar JSON)
        public Materia() { }

        // CONSTRUCTOR CON PARÁMETROS
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