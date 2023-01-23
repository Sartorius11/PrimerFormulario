using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }

        //OVERRIDE
        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }

        public override string ToString()
        {
            return this.GetNombreCompleto() + ", Salario: "
                + this.SalarioMinimo + ", Vacaciones: " + this.GetDiasVacaciones();
        }
    }
}
