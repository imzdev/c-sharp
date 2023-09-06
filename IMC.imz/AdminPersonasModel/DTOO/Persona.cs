using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.DTOO
{
    public class Persona
    {
        private string nombre;
        private uint telefono;
        private double peso;
        private double estatura;
        private double imc;

        public string Nombre { get => nombre; set => nombre = value; }
        public uint Telefono { get => telefono; set => telefono = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public double Imc { get => imc; set => imc = value; }
    }
}
