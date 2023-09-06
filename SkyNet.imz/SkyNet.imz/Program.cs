using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet.imz
{
    public partial class Program
    {
    static void Main(string[] args)
        {
            while (Menu()) ;
        }

    static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar Eliminador");
            Console.WriteLine("2. Mostrar Eliminador");
            Console.WriteLine("3. Buscar Eliminador");
            Console.WriteLine("0. Destruir SkyNet");

            switch (Console.ReadLine().Trim())

            {
                case "1":
                    IngresarEliminador();
                    break;
                case "2":
                    MostrarEliminador();
                    break;
                case "3":
                    BuscarEliminador();
                    break;
                case "0":
                    continuar = false;
                    break;
                case "9":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("INDICA BIEN EL NUMERO FILHO DP");
                    break;
            }

            return continuar;
        }
    }
}
