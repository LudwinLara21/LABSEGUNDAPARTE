using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LABSEGUNDAPARTE.Entidades
{
    class Persona
    {
        private String nombre;
        private int edad;
        private String sexo;
        private double peso;
        private double altura;

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
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
            return nombre + " " + edad + " " + sexo + " " + peso + " " + altura;
        }
    }
}

          
