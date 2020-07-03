using System;

namespace SourceCode.Modelo
{
    public class Registro
    {
        public int idRegistro { get; set; }
        public bool entrada { get; set; }
        public DateTime fechaYhora { get; set; }
        public int temperatura { get; set; }
        public string idUsuario { get; set; }

        public Registro()
        {
        }

        public Registro(bool entrada, DateTime fechaYhora, int temperatura, string idUsuario, int idRegistro = 0)
        {
            this.idRegistro = idRegistro;
            this.entrada = entrada;
            this.fechaYhora = fechaYhora;
            this.temperatura = temperatura;
            this.idUsuario = idUsuario;
        }
    }
}