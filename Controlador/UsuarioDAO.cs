using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.Modelo;

namespace SourceCode.Controlador
{
    public class UsuarioDAO
    {
        public static Usuario GetSingleUsuario(string idUsuario)
        {
            string sql =
                String.Format("select * from usuario where idUsuario = '{0}'", 
                    idUsuario);
            
            DataTable dt = Connection.ExecuteQuery(sql);

            if (dt.Rows[0] != null)
            {
                DataRow fila = dt.Rows[0];

                Usuario u = new Usuario();
                u.idUsuario = fila[0].ToString();
                u.contrasena = fila[1].ToString();
                u.nombre = fila[2].ToString();
                u.apellido = fila[3].ToString();
                u.dui = Convert.ToInt32(fila[4].ToString());
                u.fechaNacimiento = DateTime.Parse(fila[5].ToString());
                u.idDepartamento = Convert.ToInt32(fila[6].ToString());

                return u;
            }
            else
                return null;
        }
        
        public static List<Usuario> getList()
        {
            string sql = "select * from usuario";

            DataTable dt = Connection.ExecuteQuery(sql);

            List<Usuario> list = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.idUsuario = fila[0].ToString();
                u.contrasena = fila[1].ToString();
                u.nombre = fila[2].ToString();
                u.apellido = fila[3].ToString();
                u.dui = Convert.ToInt32(fila[4].ToString());
                u.fechaNacimiento = DateTime.Parse(fila[5].ToString());
                u.idDepartamento = Convert.ToInt32(fila[6].ToString());

                list.Add(u);
            }
            return list;
        }
        
        public static void AgregarUsuario(Usuario u)
        {
            string sql = String.Format(
                "insert into usuario " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                u.idUsuario, u.contrasena, u.nombre, u.apellido, u.dui, u.fechaNacimiento, u.idDepartamento);
                
            Connection.ExecuteNonQuery(sql);
        }

        public static void borrarUsuario(string idUsuario)
        {
            string sql = String.Format(
                "delete from usuario where idUsuario='{0}';",
                idUsuario);
            
            Connection.ExecuteNonQuery(sql);
        }
        
        public static List<UsuarioReducido> GetUsuariosEnEdificio()
        {
            string sql = "select usuario.idUsuario, nombre, apellido from usuario INNER JOIN registro " +
                         "ON usuario.idUsuario = registro.idUsuario where idRegistro IN " +
                         "(SELECT MAX(idRegistro) FROM registro GROUP BY idUsuario) and entrada = true;";

            DataTable dt = Connection.ExecuteQuery(sql);

            List<UsuarioReducido> list = new List<UsuarioReducido>();
            foreach (DataRow fila in dt.Rows)
            {
                UsuarioReducido u = new UsuarioReducido();
                u.idUsuario = fila[0].ToString();
                u.nombre = fila[1].ToString();
                u.apellido = fila[2].ToString();

                list.Add(u);
            }
            return list;
        }
    }
}