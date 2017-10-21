using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muebleria
{
    class Funciones1
    {
        public static bool ValidarFactura(string numFactura)
        {
            bool Verificado = false;
            string digito = "";

            if (numFactura.Length == 6)
            {
                digito = Funciones1.CortarTexto(ref numFactura);
                if (digito == "A" || digito == "B")
                {
                    digito = Funciones1.CortarTexto(ref numFactura);
                    if (digito == "-")
                    {
                        digito = Funciones1.CortarTexto(ref numFactura);
                        if (digito == "0" || digito == "1" || digito == "2" || digito == "3" || digito == "4")
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                digito = Funciones1.CortarTexto(ref numFactura);
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
            }

            return Verificado;
        }

        public static string CortarTexto(ref string numFactura)
        {
            string digito = "";
            digito = numFactura.Substring(0, 1);
            numFactura = numFactura.Substring(1);
            return digito;
        }   







    }
}
