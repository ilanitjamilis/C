using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen2doTrimestre
{
    class Funciones
    {
        public static int CantPalabras(string frase)
        {
            int cantPalabras=0;
            int posicionEspacio = 0;
            frase = frase.Trim();

            posicionEspacio = frase.IndexOf(" ");
            while (posicionEspacio > 0)
            {
                cantPalabras++;
                frase = frase.Substring(posicionEspacio + 1);
                frase = frase.Trim();
                posicionEspacio = frase.IndexOf(" ");
            }
            cantPalabras++;

            return cantPalabras;
        }

        public static int CantPalabrasImpares(string frase)
        {
            int cantPalabras = Funciones.CantPalabras(frase);
            int cantPalabrasImpares = 0;
            string palabra = "";
            int posicionEspacio = 0;
            frase = frase.Trim();

            for (int i = 1; i <= cantPalabras; i++)
            {
                if (i == cantPalabras)
                {
                    palabra = frase;
                    if (palabra.Length % 2 != 0)
                    {
                        cantPalabrasImpares++;
                    }
                }
                else
                {
                    posicionEspacio = frase.IndexOf(" ");
                    palabra = frase.Substring(0, posicionEspacio);
                    if (palabra.Length % 2 != 0)
                    {
                        cantPalabrasImpares++;
                    }
                    frase = frase.Substring(posicionEspacio + 1);
                    frase = frase.Trim();
                }
            }

            return cantPalabrasImpares;
        }

        public static int CantNumeros(string frase)
        {
            int cantNumeros = 0;
            string digito = "";
            int longitudFrase = frase.Length;

            for (int i = 1; i <= longitudFrase; i++)
            {
                digito = frase.Substring(0, 1);
                if (digito == "0" || digito == "1" || digito == "2" || digito == "3" || digito == "4" || digito == "5" || digito == "6" || digito == "7" || digito == "8" || digito == "9")
                {
                    cantNumeros++;
                }
                frase = frase.Substring(1);
            }

            return cantNumeros;
        }

        public static string NumerosPrimos(int numero1, int numero2)
        {
            string numerosPrimos = "";

            for (int i = (numero1 + 1); i < numero2; i++)
            {
                int cantDivisores = 0;
                int i2 = 2;

                while (cantDivisores == 0 && i2 < i)
                {
                    if (i % i2 == 0)
                    {
                        cantDivisores++;
                    }
                    i2++;
                }
                if (cantDivisores == 0)
                {
                    numerosPrimos += i + ", ";
                }
            }

            return numerosPrimos;
        }

    }
}
