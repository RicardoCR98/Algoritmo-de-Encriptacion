using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto2EDA_AlgoritmoEncriptacion.Logica
{
    public class Encrypt
    {
        byte[] data;
        byte[] key;
        int[,] dataMatriz;
        int[,] keyMatriz;
        public Encrypt(string mensaje, string clave) 
        {
            Console.WriteLine("ENCRIPTANDO");
            this.data = Encoding.ASCII.GetBytes(mensaje);
            this.key= Encoding.ASCII.GetBytes(clave);
        }
        //METODO 1
        public string cadenaEncryp(string clave)
        {
            string matrizStr = "";
            int[,] aux = resMatrizAscii(clave);

            for (int i = 0; i < aux.GetLength(0); i++)
            {
                for (int j = 0; j < aux.GetLength(1); j++)
                {
                    char caracter = Convert.ToChar(aux[i, j]);
                    matrizStr += caracter;
                }
            }

            return matrizStr;
        }

        //METODO 2
        //public string cadenaEncryp(string clave)
        //{
        //    int[,] aux = resMatrizAscii(clave);
        //    int[] matrizUnidimensional = Enumerable.Range(0, aux.GetLength(0))
        //                    .SelectMany(i => Enumerable.Range(0, aux.GetLength(1)).Select(j => aux[i, j]))
        //                    .ToArray();
        //    string valoresSeparados = string.Join("", matrizUnidimensional.Select(x => ((char)x).ToString()).ToArray());
        //    Console.WriteLine(valoresSeparados);

        //    return valoresSeparados;
        //}


        //METODO 3

        //public string cadenaEncryp(string clave)
        //{
        //    int[] aux = randomRowSelected(clave);
        //    string valoresSeparados = string.Join("", aux.Select(x => ((char)x).ToString()).ToArray());
        //    Console.WriteLine(valoresSeparados);

        //    return valoresSeparados;
        //}

        //public int[] randomRowSelected(string clave)
        //{
        //    int[,] aux = resMatrizAscii(clave);
        //    int randomRow = clave.Length>data.Length? clave.Length - aux.GetLength(1): clave.Length-1;

        //    int[] filaUnidimensional = new int[aux.GetLength(1)];
        //    for (int j = 0; j < aux.GetLength(1); j++)
        //    {
        //        filaUnidimensional[j] = aux[randomRow, j]; // Guardamos los valores de la fila seleccionada en la matriz unidimensional
        //    }
        //    //Imprimimos la matriz unidimensional
        //    Console.WriteLine("Fila seleccionada:");
        //    foreach (int valor in filaUnidimensional)
        //    {
        //        Console.Write(valor + " ");
        //    }
        //    Console.WriteLine("\n");
        //    return filaUnidimensional;
        //}
        public int[,] resMatrizAscii(string clave)
        {
            int x = alfa(clave);
            int[,] copyDataMatriz = dataMatriz;

            // Multiplicar la matriz por el escalar
            for (int i = 0; i < copyDataMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < copyDataMatriz.GetLength(1); j++)
                {
                    copyDataMatriz[i, j] = ((copyDataMatriz[i, j] * x ) % 33) +96;

                }
            }

            Console.WriteLine("Matriz de mensaje ya codificado\n");
            //Imprimir la matriz resultante
            for (int i = 0; i < copyDataMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < copyDataMatriz.GetLength(1); j++)
                {
                    Console.Write(copyDataMatriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            return copyDataMatriz;

        }



        public int alfa(string clave)
        {
            //Pasamos el arreglo de bytes a una matriz
            dataMatriz = matrizVignere(this.data);
            keyMatriz =  matrizVignere(this.key);

            //Ahora lo que queremos hacer es hallar el valor absoluto del determinante de la matriz de key
            int absDetMatrz = Math.Abs(DeterminanteGauss(keyMatriz));
            int alfa =absDetMatrz + clave.Length;
            Console.WriteLine(alfa);
            return Math.Abs(alfa);
        }

        public static int DeterminanteGauss(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            int det = 1;
            for (int i = 0; i < n; i++)
            {
                if (matriz[i, i] == 0)
                {
                    return 0;
                }
                for (int j = i + 1; j < n; j++)
                {
                    int factor = matriz[j, i] / matriz[i, i];
                    for (int k = i; k < n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                    }
                }
                det *= matriz[i, i];
            }
            return det;
        }

        public int[,] matrizVignere(byte[] asciiBytes)
        {
            int size = asciiBytes.Length;
            int[,] matriz = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matriz[i, j] = asciiBytes[(i + j) % size];
                }
            }

            Console.WriteLine("Matrizes de Vigenere");

            // Imprimir matriz 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matriz;
        }


    }
}
