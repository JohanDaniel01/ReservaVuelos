using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelos
{
    public class clsVuelo
    {
        public int Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadAsientos { get; set; }

        public clsVuelo(int codigo, string origen, string destino, DateTime fechasalida, int cantidadAsientos)
        {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechasalida;
            CantidadAsientos = cantidadAsientos;
        }

        public void ReservarAsiento( int cantidadAsientos)
        {
            CantidadAsientos -= cantidadAsientos;
        }
    }
}
