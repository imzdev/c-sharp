using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNetModel
{
    public class EliminadorDAL
    {
        //1. Crear una lista para guardar personas
        private static List<Eliminador> eliminadores = new List<Eliminador>();

        //2. Crear operaciones ingresar/mostrar/buscar.
        public void AgregarEliminador(Eliminador e)
        {
            eliminadores.Add(e);
        }

        public List<Eliminador> ObtenerEliminador()
        {
            return eliminadores;
        }

        public List<Eliminador> FiltrarEliminadores(string numero_serie)
        {
            //OPTIMIZAO FRACO #3 

            return eliminadores.FindAll(e => e.Numero_serie.ToLower() == numero_serie);
            // && p.Estatura > 2 (Si queremos preguntar por otro atributo+)
        }
    }
}
