using LabSegundaParte.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Entidades
{
    class Persona
    {
        private string nombre;
        private string sexo;
        private int edad;
        private double peso;
        private double altura;

       

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public Persona(double peso, double altura)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona(string nombre, string sexo, int edad)
        {
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Edad = edad;
        }

        public Persona(string nombre, string sexo, int edad, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Peso = peso;
            this.Altura = altura;
        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return "Tu nombre es: " + nombre + " tu edad es " + edad + " tu sexo es " + sexo + " tu peso es " + peso + " tu altura es " + altura;
        }
    }
}
