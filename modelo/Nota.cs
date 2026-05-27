namespace SistemaNotas.Modelo
{
    public class Nota
    {
        // ATRIBUTOS PRIVADOS
        private int idNota;
        private string periodo = string.Empty;
        private double valorNota;
        private Materia materia = null!;
        private int estudianteID;

        // PROPIEDADES PÚBLICAS
        public int IdNota
        {
            get { return idNota; }
            set { idNota = value; }
        }

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public double ValorNota
        {
            get { return valorNota; }
            set { valorNota = value; }
        }

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public int EstudianteID
        {
            get { return estudianteID; }
            set { estudianteID = value; }
        }

        // CONSTRUCTOR VACÍO (necesario para deserializar JSON)
        public Nota() { }

        // CONSTRUCTOR CON PARÁMETROS
        public Nota(int idNota, string periodo, double valorNota, Materia materia)
        {
            this.idNota = idNota;
            this.periodo = periodo;
            this.valorNota = valorNota;
            this.materia = materia;
        }

        // MÉTODO VALIDAR NOTA
        public bool ValidarNota()
        {
            if(valorNota >= 0 && valorNota <= 5)
            {
                return true;
            }

            return false;
        }

        // MÉTODO MOSTRAR NOTA
        public string MostrarNota()
        {
            return $"ID Nota: {idNota}\n" +
                   $"Periodo: {periodo}\n" +
                   $"Nota: {valorNota}";
        }
    }
}