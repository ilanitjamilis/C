using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuertos_Argentina_20._000
{
        class vuelo
        {
            public string num { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public DateTime partida { get; set; }
            public string aerolinea { get; set; }
            public decimal numPuerta { get; set; }
            public decimal precioPasaje{ get; set; }
            public decimal cantPasajeros{ get; set; }
        }
}
