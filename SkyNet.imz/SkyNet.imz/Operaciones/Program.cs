using System;
using SkyNetModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet.imz
{
    public partial class Program
    {
        static EliminadorDAL eliminadorDAL = new EliminadorDAL();

        static void BuscarEliminador()
        {
            Console.WriteLine("Ingrese nombre");
            new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim())
                .ForEach(e => Console.WriteLine("Nombre: {0}, Peso: {1}", e.Numero_serie, e.Tipo));

            List<Eliminador> eliminadores = new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim());
            foreach (Eliminador e in eliminadores)
            {
                Console.WriteLine("Nombre: {0}, Peso: {1}", e.Numero_serie, e.Tipo);
            }
        }
        static void MostrarEliminador()
        {
            List<Eliminador> eliminadores = eliminadorDAL.ObtenerEliminador();
            for (int i = 0; i < eliminadores.Count; i++)
            {
                Eliminador actual = eliminadores[i];
                Console.WriteLine("{0}: Nombre: {1} Tipo: {2}", i, actual.Numero_serie, actual.Tipo);
            }

        }
        static void IngresarEliminador()
        {
            //Asignamos variables
            string numero_serie;
            string tipo;
            int prioridad_base;
            string objetivo;
            Int32 destino;

        Console.WriteLine("Bienvenido a una cmd xitada !");
            bool esValido;

            do
            {
                Console.WriteLine("Ingrese Numero de Serie: ");
                numero_serie = Console.ReadLine().Trim();

            } while (numero_serie.Equals(string.Empty));

            {
                Console.WriteLine("Ingrese Tipo: ");
                tipo = Console.ReadLine().Trim();

            } while (tipo.Equals(string.Empty)) ;

            do
            {
                Console.WriteLine("Ingrese Objetivo: ");
                objetivo = Console.ReadLine().Trim();
            } while (objetivo.Equals(string.Empty));

            do
            {
                Console.WriteLine("Ingrese Destino: ");
                esValido = Int32.TryParse(Console.ReadLine().Trim(), out destino);
            } while (!esValido);
            Console.Clear();


            Eliminador e = new Eliminador()
            {
                Numero_serie = numero_serie,
                Tipo = tipo,
                Objetivo = objetivo,
                Destino = destino


            };
            
            eliminadorDAL.AgregarEliminador(e);


            Console.WriteLine("Numero de Serie : {0}", e.Numero_serie);
            Console.WriteLine("Tipo : {0}", e.Tipo);
            
            /*Console.WriteLine("Peso : {0}", p.Peso);
            Console.WriteLine("Estatura : {0}", p.Estatura);
            Console.WriteLine("IMC es : {0}", p.IMC.Valor);
            Console.WriteLine("Rango de IMC : {0}", p.IMC.Texto);*/

        }

    }
}