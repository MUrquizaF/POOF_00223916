using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Modelo;

namespace SourceCode.Controlador
{
    public class RegistroDAO
    {
        public static List<Registro> getList()
        {
            string sql = "select * from registro";

            DataTable dt = Connection.ExecuteQuery(sql);

            List<Registro> list = new List<Registro>();
            foreach (DataRow fila in dt.Rows)
            {
                Registro r = new Registro();
                r.idRegistro = Convert.ToInt32(fila[0].ToString());
                r.entrada = Convert.ToBoolean(fila[1].ToString());
                r.fechaYhora = Convert.ToDateTime(fila[2].ToString());
                r.temperatura = Convert.ToInt32(fila[3].ToString());
                r.idUsuario = fila[4].ToString();

                list.Add(r);
            }
            return list;
        }
        
        public static void AgregarRegistro(Registro r)
        {
            string sql = String.Format(
                "insert into registro" +
                "(entrada, fechayhora, temperatura, idUsuario) " +
                "values ('{0}', '{1}', '{2}', '{3}');",
                r.entrada, r.fechaYhora, r.temperatura, r.idUsuario);
                
            Connection.ExecuteNonQuery(sql);
        }
        
        public static List<Registro> getListSingleUser(string idUsuario)
        {
            string sql = 
                String.Format("select * from registro where idUsuario = '{0}' order by idRegistro desc;",
                    idUsuario);

            DataTable dt = Connection.ExecuteQuery(sql);

            List<Registro> list = new List<Registro>();
            foreach (DataRow fila in dt.Rows)
            {
                Registro r = new Registro();
                r.idRegistro = Convert.ToInt32(fila[0].ToString());
                r.entrada = Convert.ToBoolean(fila[1].ToString());
                r.fechaYhora = Convert.ToDateTime(fila[2].ToString());
                r.temperatura = Convert.ToInt32(fila[3].ToString());
                r.idUsuario = fila[4].ToString();

                list.Add(r);
            }
            return list;
        }
    }
}