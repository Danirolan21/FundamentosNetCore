using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1400;
        }
        public int GetSalarioMinimo() 
        { 
            return this.SalarioMinimo; 
        }
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("Empleado GetDiasVacaciones");
            return 22;
        }
        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO 2 parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
