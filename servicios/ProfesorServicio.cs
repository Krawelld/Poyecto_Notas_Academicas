using SistemaNotas.Modelo;
using System.Text.Json;

namespace SistemaNotas.Servicios
{
    public class ProfesorServicio
    {
        private string rutaUsuarios = "Datos/Usuarios.json";
        private string rutaNotas = "Datos/Notas.json";

        // Ver todos los estudiantes
        public Persona[] ObtenerEstudiantes()
        {
            string json = File.ReadAllText(rutaUsuarios);
            Persona[] usuarios = JsonSerializer.Deserialize<Persona[]>(json);

            List<Persona> estudiantes = new List<Persona>();

            foreach (Persona usuario in usuarios)
            {
                if (usuario.Rol.ToLower() == "estudiante")
                {
                    estudiantes.Add(usuario);
                }
            }

            return estudiantes.ToArray();
        }

        // Agregar una nota nueva al JSON
        public void AgregarNota(int estudianteID, string periodo, double valorNota, string codigoMateria, string nombreMateria)
        {
            string json = File.ReadAllText(rutaNotas);
            List<Nota> notas = JsonSerializer.Deserialize<List<Nota>>(json);

            // Generar nuevo ID
            int nuevoId = 1;
            foreach (Nota n in notas)
            {
                if (n.IdNota >= nuevoId)
                {
                    nuevoId = n.IdNota + 1;
                }
            }

            // Crear la nota nueva
            Nota nuevaNota = new Nota();
            nuevaNota.IdNota = nuevoId;
            nuevaNota.Periodo = periodo;
            nuevaNota.ValorNota = valorNota;
            nuevaNota.Materia = new Materia(codigoMateria, nombreMateria);
            nuevaNota.EstudianteID = estudianteID;

            notas.Add(nuevaNota);

            // Guardar en el JSON
            string nuevoJson = JsonSerializer.Serialize(notas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaNotas, nuevoJson);
        }

        // Modificar una nota existente
        public void ModificarNota(int idNota, double nuevoValor)
        {
            string json = File.ReadAllText(rutaNotas);
            List<Nota> notas = JsonSerializer.Deserialize<List<Nota>>(json);

            foreach (Nota nota in notas)
            {
                if (nota.IdNota == idNota)
                {
                    nota.ValorNota = nuevoValor;
                    break;
                }
            }

            // Guardar cambios
            string nuevoJson = JsonSerializer.Serialize(notas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaNotas, nuevoJson);
        }

        // Obtener notas de un estudiante (para modificar)
        public Nota[] ObtenerNotasPorEstudiante(int estudianteID)
        {
            string json = File.ReadAllText(rutaNotas);
            Nota[] todasLasNotas = JsonSerializer.Deserialize<Nota[]>(json);

            List<Nota> notasEstudiante = new List<Nota>();

            foreach (Nota nota in todasLasNotas)
            {
                if (nota.EstudianteID == estudianteID)
                {
                    notasEstudiante.Add(nota);
                }
            }

            return notasEstudiante.ToArray();
        }
    }
}
