using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABSEGUNDAPARTE.Entidades;
using LABSEGUNDAPARTE.Negocio;

namespace LABSEGUNDAPARTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persoona = new Persona();
            ClsPersona clspersona = new ClsPersona();

            Console.WriteLine("Digite su nombre");
            String nombre = (Console.ReadLine());

            Console.WriteLine("Digite su genero H o M");
            String sexo = (Console.ReadLine());

            Console.WriteLine("Digite su edad");
            int edad = Convert.ToInt32(Console.ReadLine ());

            Console.WriteLine("Escriba su peso");
            Double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba su altura");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Persona constructor1= new Persona(nombre, edad, sexo, peso, altura);
            Persona constructor2  = new Persona(nombre, sexo, edad);

            Console.WriteLine(clspersona.CalcularIMC(constructor1));

            Console.WriteLine(clspersona.CalcularIMC(constructor2));


            Console.WriteLine(constructor1.ToString());
            Console.ReadLine();



        }
    }
}
