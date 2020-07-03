using System;

namespace SourceCode.Modelo
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dui { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idDepartamento { get; set; }

        public Usuario()
        {
        }

        public Usuario(string idUsuario, string contrasena, string nombre, string apellido, int dui, DateTime fechaNacimiento, int idDepartamento)
        {
            this.idUsuario = idUsuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dui = dui;
            this.fechaNacimiento = fechaNacimiento;
            this.idDepartamento = idDepartamento;
        }

        public Usuario(string idUsuario, string nombre, string apellido)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}