using System;
using SourceCode.Controlador;

namespace SourceCode.Patrón
{
    public class ProxyAcceso
    {
        public interface ISujeto
        {
            bool PeticionAcceso(string idUsuario, string contrasena);
        }
        
        public class ProxySeguro : ISujeto
        {
            private Acceso A = new Acceso();
            
            public bool PeticionAcceso(string idUsuario, string contrasena)
            {
                return A.CheckValidLogin(idUsuario, contrasena);
            }
        }

        public class Acceso
        {
            public bool CheckValidLogin(string idUsuario, string contrasena)
            {
                string sql = String.Format(
                    "SELECT CASE WHEN EXISTS (SELECT * FROM usuario WHERE idUsuario = '{0}' and contrasena = '{1}') THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END;",
                    idUsuario, contrasena);
                return Connection.ExecuteCheckQuery(sql);
            }
        }
    }
}