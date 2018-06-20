using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal
{
    class Validadores
    {
        //publi static es para que en la app pueda ser visible en todo la app
        public static bool numerico(char e)
        {
            string CaracteresPermitidos = "0123456789\b";
            bool existe;


            existe = CaracteresPermitidos.Contains(e); //devolver true si el char e es permitido

            if (existe == true)
            {
                return false; //permite escribir el caracter em el texbox
            }
            else
            {
                return true; //el true evita esxribir el caracter en el texbox
            }

        }


        //publi static es para que en la app pueda ser visible en todo la app
        public static bool caracteres(char e)
        {
            string CaracteresPermitidos = "QWERTYUIOPASDFGHJKLZXCVBNMÑqwertyuiopasdfghjklzxcvbnmñ éáíóú\b"; // \b es backspace 
            bool existe;


            existe = CaracteresPermitidos.Contains(e); //devolver true si el char e es permitido

            if (existe == true)
            {
                return false; //permite escribir el caracter em el texbox
            }
            else
            {
                return true; //el true evita esxribir el caracter en el texbox
            }

        }


        //publi static es para que en la app pueda ser visible en todo la app
        public static bool caracteres_Numeros(char e)
        {
            string CaracteresPermitidos = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMÑqwertyuiopasdfghjklzxcvbnmñ éáíóú\b"; // \b es backspace 
            bool existe;


            existe = CaracteresPermitidos.Contains(e); //devolver true si el char e es permitido

            if (existe == true)
            {
                return false; //permite escribir el caracter em el texbox
            }
            else
            {
                return true; //el true evita esxribir el caracter en el texbox
            }

        }


    }

}   
