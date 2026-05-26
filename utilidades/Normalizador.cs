namespace SistemaNotas.Utilidades
{
    public static class Normalizador
    {
        // NORMALIZAR TEXTO
        public static string NormalizarTexto(
            string texto
        )
        {
            return texto.Trim();
        }

        // NORMALIZAR NOMBRE
        public static string NormalizarNombre(
            string nombre
        )
        {
            nombre = nombre.Trim();

            return System.Globalization
                .CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(nombre.ToLower());
        }

        // NORMALIZAR CORREO
        public static string NormalizarCorreo(
            string correo
        )
        {
            return correo
                .Trim()
                .ToLower();
        }

        // NORMALIZAR DOCUMENTO
        public static string NormalizarDocumento(
            string documento
        )
        {
            return new string(
                documento
                    .Where(char.IsDigit)
                    .ToArray()
            );
        }

        // VALIDAR NOTA
        public static bool ValidarNota(
            double nota
        )
        {
            return nota >= 0 && nota <= 5;
        }
    }
}