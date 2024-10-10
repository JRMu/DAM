﻿using System;
namespace VT03_Practica
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--------------------------- Declaracion de variables
            //- Enteros
            short num1 = 90;
            int num2 = 10;
            long num3 = num1 + num2; ;
            //- Decimales
            double num4 = 8.9;
            float num5 = 8.9f;
            decimal num6 = 8.9M;
            //- Booleanos
            bool booleano1 = true;
            bool booleano2 = false;
            booleano1 = (num1 < num2);
            //- Caracteres
            string palabra1 = "";
            string palabra2 = "Hola onliners";
            //--------------------------- Operaciones aritméticas
            //- Sintáxis clásica
            long num7 = 10;
            //num7 = num1 + num2;
            //num7 = num1 - num2;
            //num7 = num1 * num2;
            //num7 = num1 / num2;
            //num7 = num1 % num2;
            //- Sintaxis incremental num7 = 10
            long num8 = num7++;
            long num9 = ++num7;
            //- Sintaxis incremental reducida
            //--------------------------- Operaciones lógicas
            //- AND
            bool boleano3 = (1 == 1) && (1 == 1) && (1 == 2);
            //- OR
            bool boleano4 = (1 == 2) || (1 == 2) || (1 == 2);
            //- XOR
            bool boleano5 = (1 == 1) ^ (1 == 2) ^ (1 == 1) ^ (1 == 1);
            // Paso 01 - V ^ F ========> V
            // Paso 02 - V ^ V ========> F
            // Paso 03 - F ^ V ========> V
            //--------------------------- Operaciones con cadenas de texto
            string cadena4 = "Hola onliners ";
            string cadena5 = "";
            int largo = cadena4.Length;
            cadena5 = cadena4.Trim();
            bool booleano9 = cadena4.Contains("a onliners");
            cadena5 = cadena4.Substring(5, 8);
            cadena5 = cadena5.ToUpper();
            cadena5 = cadena5.ToLower();
            //--- Fin de la ejecución del programa
        }
    }
}