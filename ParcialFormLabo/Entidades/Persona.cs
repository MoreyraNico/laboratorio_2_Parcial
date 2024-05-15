using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;        
        protected DateTime nacimiento;        
        protected string barrioResidencia;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;            
            this.nacimiento = nacimiento;            
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get 
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get 
            {
                return $"{apellido}, {nombre}";
            }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

        internal abstract string FichaExtra();
        
        public string FichaPersonal(Persona p)
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendLine($"{NombreCompleto}");
            ficha.AppendLine($"{Edad}");
            ficha.AppendLine($"{barrioResidencia}");

            return ficha.ToString();
        }

    }
}
