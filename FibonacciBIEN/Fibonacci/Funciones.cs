using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Funciones
    {
        public static string vecesNumero(int cantidad)
        {
            int pri = 0;
            int seg = 1;
            int ter = 0;
            string resultado = "";

            if (cantidad == 1)
            {
                resultado = "0";
            }
            else
            {
                if (cantidad == 2)
                {
                    resultado = "0, 1";
                }
                else
                {
                    resultado = "0, 1, ";

                    for (int i = 3; i <= cantidad; i++)
                    {
                        ter = pri + seg;
                        resultado += ter + ", ";
                        pri = seg;
                        seg = ter;
                    }

                }
            }

            return resultado;
        }

        public static string hastaX(int cantidad)
        {
            int pri = 0;
            int seg = 1;
            int ter = 0;
            string resultado = "";

            if (cantidad == 0)
            {
                resultado = "0";
            }
            else
            {
                if (cantidad == 1)
                {
                    resultado = "0,1";
                }
                else
                {
                    resultado = "0, 1, ";

                    for (int i = 0; pri+seg <= cantidad; i++)
                    {
                        ter = pri + seg;
                        resultado += ter + ", ";
                        pri = seg;
                        seg = ter;
                    }
                }
            }

            return resultado;
        }

        public static bool existeN(int cantidad)
        {
            int pri = 0;
            int seg = 1;
            int ter = 0;
            bool resultado = false;

            if (cantidad == 0)
            {
                resultado = true;
            }
            else
            {
                for (int i = 0; i <=cantidad; i++)
                {
                    ter = pri + seg;
                    if (ter == cantidad)
                    {
                        resultado = true;
                        break;
                    }
                    pri = seg;
                    seg = ter;
                }
            }

            return resultado;
        }


    }
}