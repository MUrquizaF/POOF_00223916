using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Modelo;

namespace SourceCode.Controlador
{
    public class DepartamentoDAO
    {
        public static string GetNombreDepartamento(int idDepartamento)
        {
            string sql = String.Format("select nombre from departamento where idDepartamento = {0};",
                idDepartamento);
            return Connection.ExecuteStringQuery(sql);
        }
        
        public static List<Departamento> getList()
        {
            string sql = "select * from departamento";

            DataTable dt = Connection.ExecuteQuery(sql);

            List<Departamento> list = new List<Departamento>();
            foreach (DataRow fila in dt.Rows)
            {
                Departamento d = new Departamento();
                d.idDepartamento = Convert.ToInt32(fila[0].ToString());
                d.nombre = fila[1].ToString();
                d.ubicacion = fila[2].ToString();

                list.Add(d);
            }
            return list;
        }

        public static Frequencia BuscarDepartamentoConcurrido()
        {
            string sql =
                "SELECT d.nombre, count(u.idDepartamento) as frecuencia FROM REGISTRO r, DEPARTAMENTO d, " +
                "USUARIO u WHERE r.idUsuario = u.idUsuario AND d.idDepartamento = u.idDepartamento " +
                "GROUP BY d.idDepartamento ORDER BY frecuencia DESC LIMIT 1;";
            
            DataTable dt = Connection.ExecuteQuery(sql);

            if (dt.Rows[0] != null)
            {
                DataRow fila = dt.Rows[0];

                Frequencia f = new Frequencia();
                f.nombre = fila[0].ToString();
                f.frecuencia = Convert.ToInt32(fila[1].ToString());

                return f;
            }
            else
                return null;
        }
    }
}