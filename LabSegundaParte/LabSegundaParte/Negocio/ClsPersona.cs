using LabSegundaParte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Negocio
{
    class ClsPersona
    {

        public String calcularIMC(Persona cons1)
        {
            double pro = cons1.Peso / Math.Pow(cons1.Altura, 2);

            if (pro < 20)
            {
                return "el peso es ideal";
            }
            if (pro > 25)
            {
                return "tiene sobre peso";
            }
            else
                return "";
            
        }

        public String MayorDeEdad(Persona cons1)
        {
            if (cons1.Edad >= 18)
            {
                return "el usuario es mayor de edad";

            }
            else
                return "el usuario es menor de edad";
        }
    }
}
