using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaBinaria
{
    class Vector
    {
        int[] vector;
        Random random = new Random();
        public int comp { get; private set; }

        public Vector(int tamanio)
        {
            vector = new int[tamanio];
        }

        public void llenar(int limite)
        {
            for (int i = 0; i != vector.Length; i++)
            {
                vector[i] = random.Next(1, 30); 
            }
        }

        public string mostrar()
        {
            string numeros = "";
            
            for (int i = 0; i != vector.Length; i++)
            {
                numeros += "[" + (i) + "] = " + (vector[i]) + Environment.NewLine;
            }                                    

            return numeros;
        }

        public void ordenar()
        {
            Array.Sort(vector);
        }

        public int busquedaBinaria(int numero)
        {
            int limInf = 0;
            int limSup = vector.Length - 1;
            int guess = 0;

            while (limSup >= limInf)
            {
                guess = Convert.ToInt16(Math.Floor(Convert.ToDouble((limInf + limSup) / 2)));

                if (vector[guess] == numero)
                {
                    comp++;
                    return guess;
                }

                if (vector[guess] < numero)
                {   
                    limInf = guess + 1;
                    comp++;
                }
                else
                {
                    limSup = guess - 1;
                    comp++;
                }
            }

            return -2;
        }
    }
}
