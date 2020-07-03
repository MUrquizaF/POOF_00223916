using System;

namespace SourceCode.Patrón.Estrategia
{
    public class CPersonal : IDepartamento
    {
        public bool PerteneceADepartamento(string nombreDepartamento)
        {
            return nombreDepartamento.Equals("personal", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}