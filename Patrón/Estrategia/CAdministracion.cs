using System;

namespace SourceCode.Patrón.Estrategia
{
    public class CAdministracion : IDepartamento
    {
        public bool PerteneceADepartamento(string nombreDepartamento)
        {
            return nombreDepartamento.Equals("administracion", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}