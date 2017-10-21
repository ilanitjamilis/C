using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuertos_Argentina_20._000
{
    class Funciones
    {

        public static bool ValidarNumeroVuelo(string numVuelo)
        {
            bool Verificado = false;

            if (numVuelo.Length == 6)
            {
                string digito = "";
                digito = Funciones.CortarTexto(ref numVuelo);
                if (digito == "A")
                {
                    digito = Funciones.CortarTexto(ref numVuelo);
                    if (digito == "A")
                    {
                        digito = Funciones.CortarTexto(ref numVuelo);

                        for (int i = 1; i <= 4; i++)
                        {
                            if (i < 4)
                            {
                                digito = Funciones.CortarTexto(ref numVuelo);
                            }
                            if (digito == "0" || digito == "1" || digito == "2" || digito == "3" || digito == "4" || digito == "5" || digito == "6" || digito == "7" || digito == "8" || digito == "9")
                            {
                                Verificado = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return Verificado;
        }

        public static string CortarTexto(ref string numVuelo)
        {
            string digito = "";
            digito = numVuelo.Substring(0, 1);
            numVuelo = numVuelo.Substring(1);
            return digito;
        }

        public static bool ValidarPuerta(int Num, List<vuelo> lista)
        {
            bool verificar = false;
            foreach (vuelo objeto in lista)
            {
                if (Num == objeto.numPuerta)
                {
                    verificar = true;
                    break;
                }
            }
            return verificar;
        }

    }
}
