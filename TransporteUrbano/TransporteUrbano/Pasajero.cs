using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransporteUrbano
{
    class Pasajero
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal saldo { get; set; }
        public List<Viaje> Viajes { get; set; }
    }
}
