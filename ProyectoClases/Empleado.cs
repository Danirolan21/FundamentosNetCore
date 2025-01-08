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
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
        }
        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO 2 parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
