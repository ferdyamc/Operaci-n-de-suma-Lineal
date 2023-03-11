using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Operaciones
    {
        //Atributos--------------------------------------------------------------------------------------------------------------------
        public int num1;
        public int num2;
        public int cantidad_veces_llevadas=0;
        public List<int> ListaCifrasllevadas = new List<int>();         

        //Constructor------------------------------------------------------------------------------------------------------------------
        public Operaciones(int _num1, int _num2)
        {
            this.num1 = _num1;//Dar valor a num1
        ;   this.num2 = _num2;//Dar valor a num2
            Operacion();//Llamar al metodo Operación para que se ejecute una vez se genere la instacia y sus atirbutos num1 y num2 tengan valor
        }

        //Metodo para operar los numeros-----------------------------------------------------------------------------------------------
        public void Operacion() {

            //variables locales del metodo
            int mod1, mod2, valor;
            bool estado = false;

            //Bucle while para sacar los mods de los 2 numeros y realizar la operación de suma lineal (el while es ejecutado mietras la operación no este lista)
            while (estado != true)
            {
                if (num1 != 0 && num2 != 0)//Si ambos numeros son diferentes de cero, es porque aun se les debe sacar el mod y contiuar operandolos
                {
                    valor = 0;
                    mod1 = num1 % 10;
                    mod2 = num2 % 10;
                    valor = mod1 + mod2;

                    if (valor > 9) //Si el resultado de la suma lineal es mayor a 9, es porque el numero debe llevar una cifra en la siguiente opeación
                    {
                        valor = valor / 10;
                        ListaCifrasllevadas.Add(valor);
                        cantidad_veces_llevadas++;
                    }
                    //Luego de divide num1 y num2 por 10 para reducirles una cifra
                    num1 = num1 / 10;
                    num2 = num2 / 10;

                    if (num1 == 0 || num2 == 0) //Si alguno de los dos numeros es igual a 0 , se realiza una ultima operación y se rompe el blucle (Si no, continua operando)
                    {
                        if (num1 == 0 && num2 != 0)//Si num2 aun es diferente de 0, solo se suma num2 mas la cifra que lleva de la anterior operación (si es que lleva)
                        {
                            valor = num2 + valor;
                        }
                        else//Si num1 aun es diferente de 0, solo se suma num1 mas la cifra que lleva de la anterior operación (si es que lleva)
                        {
                            valor = num1 + valor;
                        }
                        estado = true;
                        break; 
                    }
                }
            }
            //Imprimir salida
            Console.WriteLine($"Cantidad: " + cantidad_veces_llevadas);//Numero de veces que llevo
            Console.Write($"Cifras llevadas: ");//Cifras llevadas durante la operación
            foreach (var i in ListaCifrasllevadas)
            {
                Console.Write(i+" ");
            }
        }
    }
}
