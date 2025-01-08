using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Console.WriteLine("Constructor Director");
            this.SalarioMinimo += 200;
        }

        //METODO SOBREESCRITO
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("Director GetDiasVacaciones");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }

        //METODO IMPLEMENTADO
        public int GetDiasVacaciones(int extras)
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
