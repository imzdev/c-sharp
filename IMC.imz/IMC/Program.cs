using IMC.DTOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    public  partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu());
        }



        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("9. Limpiar");
            Console.WriteLine("0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarPersona();
                    break;
                case "2": MostrarPersona();
                    break;
                case "3": BuscarPersona();
                    break;
                case "9": Console.Clear();
                    break;
                case "0": continuar = false;
                    break;
                default: Console.WriteLine("INDICA BIEN EL NUMERO");
                    break;
            }
            return continuar;
        }
        static void IngresarPersona()
        {
            //Asignamos variables
            string nombre;
            uint telefono;
            double peso;
            double estatura;
            double imc;


            bool esValido;

            do
            {
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine().Trim();

            } while (nombre.Equals(string.Empty));

            do
            {
                Console.WriteLine("Ingrese telefono: ");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese peso: ");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese estatura: ");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);

            imc = peso / (estatura * estatura);

            //DTO

            Persona p = new Persona();
            p.Nombre = nombre;

            Console.WriteLine("Nombre : {0}", nombre);
            Console.WriteLine("Telefono : {0}", telefono);
            Console.WriteLine("Peso : {0}", peso);
            Console.WriteLine("Estatura : {0}", estatura);
            Console.WriteLine("IMC es : {0}", imc);

            Console.ReadKey();
        }
        static void BuscarPersona()
        {

        }
        static void MostrarPersona()
        {

        }
    }
}
