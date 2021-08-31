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
        Persona pers = new Persona();

        public String calcularIMC(Persona pers)
        {
            double pro = pers.Peso / Math.Pow(pers.Altura, 2);

            if (pro < 20)
            {
                return "el peso es ideal";
            }
            else
            
                return "tiene sobre peso";
            
            
        }

        public String MayorDeEdad()
        {
            if (pers.Edad >= 18)
            {
                return "el usuario es mayor de edad";

            }
            else
                return "el usuario es menor de edad";
        }
    }
}
