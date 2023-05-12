using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaEmpleado
{
     class Empleado
    {

        public string Nombre = "Jacobo Agami";
        public string Apellido = " Agami";
        public int SueldoDirio = 500;


        public string Nombre1 = " Alvaro ";
        public string Apellido1 = " Gonzalez ";
        public int SueldoDirio1 = 400;


        public string Nombre2 = " Mario ";
        public string Apellido2 = " Ramon ";
        public int SueldoDirio2 = 300;



        public int CalcularSueldo { get; set; }
        public string DiasTrabajo { get; set; }
    }
}
