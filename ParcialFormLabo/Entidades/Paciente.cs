using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        {

        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }
            set
            {
                diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendLine($"Reside en:{barrioResidencia}");
            ficha.AppendLine($"Diagnostico: {Diagnostico}");

            return ficha.ToString();

        }
    }
}
