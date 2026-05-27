using SistemaNotas.Modelo;
using System.Text.Json;

namespace SistemaNotas.Servicios
{
    public class NotasServicio
    {
        private string ruta = "Datos/Notas.json";

        // Obtener notas de un estudiante por su ID
        public Nota[] ObtenerNotasPorEstudiante(int estudianteID)
        {
            // 1. Leer JSON
            string json = File.ReadAllText(ruta);

            // 2. Deserializar todas las notas
            Nota[] todasLasNotas = JsonSerializer.Deserialize<Nota[]>(json);

            // 3. Filtrar las notas del estudiante
            List<Nota> notasEstudiante = new List<Nota>();

            foreach (Nota nota in todasLasNotas)
            {
                if (nota.EstudianteID == estudianteID)
                {
                    notasEstudiante.Add(nota);
                }
            }

            // 4. Devolver como arreglo
            return notasEstudiante.ToArray();
        }
    }
}
