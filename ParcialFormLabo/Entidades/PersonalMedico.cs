using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder fichaPersonalMedico = new StringBuilder();
            fichaPersonalMedico.AppendLine($"Finalizo Residendia: {esResidente}");
            fichaPersonalMedico.AppendLine("ATENCIONES:");
            fichaPersonalMedico.AppendLine($"{consultas.ToString()}");

            return fichaPersonalMedico.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }

    }
}
