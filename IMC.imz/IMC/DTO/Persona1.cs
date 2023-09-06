using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC.DTO
{
    //Clase publica
    public class Persona
    {
        //Generamos contructo get and set ctrl+. en el atributo "nombre"
        private string nombre;
        uint telefono;
        double peso;
        double estatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public uint Telefono { get => telefono; set => telefono = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Estatura { get => estatura; set => estatura = value; }
    }
}