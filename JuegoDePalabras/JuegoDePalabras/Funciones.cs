using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoDePalabras
{
    class Funciones
    {

        public static  int CantA (string texto)
        {
            int cantA = 0;

            if (texto.IndexOf("a") >= 0)
            {
                while (texto.IndexOf("a") >-1)
                {
                    cantA += 1;
                    int posicionA = texto.IndexOf("a");
                    texto = texto.Substring(posicionA + 1);
                }
            }
            
            return cantA;
        }

        public static int CantE(string texto)
        {
            int cantE = 0;
            int cont = 0;

            if (texto.IndexOf("e") >= 0)
            {
                while (texto.IndexOf("e") >= 0)
                {
                    cont++;
                    cantE += 1;
                    int posicionE = texto.IndexOf("e");
                    texto = texto.Substring(posicionE + 1);
                }
            }
            
            return cantE;
        }

        public static int CantI(string texto)
        {
            int cantI = 0;
            int cont = 0;

            if (texto.IndexOf("i") >= 0)
            {
                while (texto.IndexOf("i") >= 0)
                {
                    cont++;
                    cantI += 1;
                    int posicionI = texto.IndexOf("i");
                    texto = texto.Substring(posicionI + 1);
                }
            }
                
            return cantI;
        }

        public static int CantO(string texto)
        {
            int cantO = 0;
            int cont = 0;

            if (texto.IndexOf("o") >= 0)
            {
                while (texto.IndexOf("o") >= 0)
                {
                    cont++;
                    cantO += 1;
                    int posicionO = texto.IndexOf("o");
                    texto = texto.Substring(posicionO + 1);
                }
            }
                
            return cantO;
        }

        public static int CantU(string texto)
        {
            int cantU = 0;
            int cont = 0;

            if (texto.IndexOf("u") >= 0)
            {
                while (texto.IndexOf("u") >= 0)
                {
                    cont++;
                    cantU += 1;
                    int posicionU = texto.IndexOf("u");
                    texto = texto.Substring(posicionU + 1);
                }
            }
               
            return cantU;
        }

        public static int cantConsonantes(string texto)
        {
            int cantConsonantes = texto.Length - (CantA(texto) + CantE(texto) + CantI(texto) + CantO(texto) + CantU(texto));
            return cantConsonantes;
        }

        public static int cantPalabras(string texto)
        {
            int cantiPalabras = 0;
            texto = texto.Trim();
            if (texto.IndexOf(" ") > 0)
            {
                while (texto.IndexOf(" ") > 0)
                {
                    int posicionEspacio = texto.IndexOf(" ");
                    cantiPalabras++;
                    texto = texto.Substring(posicionEspacio+1);
                    texto = texto.Trim();
                }
                
            }
            return (cantiPalabras + 1);

        }

        public static bool fraseCapicua(string texto)
        {
            bool capicua = false;

            string letra1 = "";
            string letra2 = "";
            texto = texto.Trim();
            int cantCaracteres = texto.Length;
            letra2 = texto.Substring(cantCaracteres - 1);
            letra1 = texto.Substring(0, 1);

            while (letra1 == letra2 && cantCaracteres>=2)
            {
                texto = texto.Substring(1, cantCaracteres - 2);
                texto = texto.Trim();
                cantCaracteres = texto.Length;
                letra2 = texto.Substring(cantCaracteres - 1);
                letra1 = texto.Substring(0, 1);
                if ((cantCaracteres==1) || (letra1 == letra2 && cantCaracteres==2))
                {
                    capicua = true;
                }
            }

            return capicua;
        }
        
    }
}
