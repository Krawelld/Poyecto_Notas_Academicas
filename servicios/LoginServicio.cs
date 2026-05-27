using SistemaNotas.Modelo;
using SistemaNotas.Utilidades;
using System.Text.Json;

namespace SistemaNotas.Servicios
{
    public class LoginServicio
    {
        private string ruta = "Datos/Usuarios.json";

        public Persona Login(string correo, string password)
        {
            // 1. Leer JSON
            string json = File.ReadAllText(ruta);

            // 2. Convertir a arreglo de personas
            Persona[] usuarios =
                JsonSerializer.Deserialize<Persona[]>(json);

            // 3. Buscar usuario
            correo = Normalizador.NormalizarCorreo(correo);

            foreach (Persona usuario in usuarios)
            {
                if (usuario.Correo == correo &&
                    usuario.Password == password)
                {
                    return usuario;
                }
            }

            // 4. Si no encuentra nada
            return null;
        }

        // Obtener grado de un estudiante por su ID
        public string ObtenerGrado(int id)
        {
            string json = File.ReadAllText(ruta);

            // Leer como documento genérico para acceder al campo Grado
            JsonDocument documento = JsonDocument.Parse(json);

            foreach (JsonElement elemento in documento.RootElement.EnumerateArray())
            {
                if (elemento.GetProperty("ID").GetInt32() == id)
                {
                    if (elemento.TryGetProperty("Grado", out JsonElement grado))
                    {
                        return grado.GetString() ?? "";
                    }
                }
            }

            return "";
        }
    }
}