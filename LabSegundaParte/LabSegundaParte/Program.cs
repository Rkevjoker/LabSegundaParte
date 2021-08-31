using LabSegundaParte.Entidades;
using LabSegundaParte.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe cual es tu genero: ");
            String sexo = Console.ReadLine();

            Console.WriteLine("Escribe cual es tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe cual es tu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe cual es tu altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());


            Persona cons1 = new Persona(nombre, sexo, edad, peso, altura);
            Persona cons2 = new Persona(nombre, sexo, edad);

            ClsPersona cls = new ClsPersona();
            Console.WriteLine(cls.calcularIMC(cons1));
            Console.WriteLine(cls.MayorDeEdad(cons1));

            Console.WriteLine(cons1.ToString());
            Console.ReadLine();




        }
    }
}
