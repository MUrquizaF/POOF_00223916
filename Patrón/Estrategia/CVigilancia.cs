using System;

namespace SourceCode.Patrón.Estrategia
{
    public class CVigilancia : IDepartamento
    {
        public bool PerteneceADepartamento(string nombreDepartamento)
        {
            return nombreDepartamento.Equals("Vigilancia", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}