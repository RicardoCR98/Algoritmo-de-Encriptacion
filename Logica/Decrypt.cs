using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2EDA_AlgoritmoEncriptacion.Logica
{
    public class Decrypt
    {
        byte[] dataEncrypt;
        byte[] key;
        int[,] dataMatriz;
        int[,] keyMatriz;
        public Decrypt(string msgEncrypt, string clave) 
        {
            Console.WriteLine("DESENCRIPTANDO");
            this.dataEncrypt = Encoding.ASCII.GetBytes(msgEncrypt);
            this.key = Encoding.ASCII.GetBytes(clave);
            Console.WriteLine("\n");
            
            Console.WriteLine("\n");

        }

        public string cadenaOriginal(string clave)
        {
            int[,] decryptedMatriz = resMatrizAscii(clave);
            int[] decryptedArray = decryptedMatriz.Cast<int>().ToArray();
            char[] decryptedChars = new char[decryptedArray.Length];

            for (int i = 0; i < decryptedArray.Length; i++)
            {
                decryptedChars[i] = Convert.ToChar(decryptedArray[i] + 1+96);
            }

            string decryptedString = new string(decryptedChars);

            Console.WriteLine("Mensaje desencriptado: " + decryptedString);
            return decryptedString;
        }

        //desencriptar el ascii en la función resMatrizAscii
        public int[,] resMatrizAscii(string clave)
        {
            dataMatriz = byteToMrtz(dataEncrypt, clave);
            int x = alfaEncrypt(clave);
            int[,] copyDataMatriz = (int[,])dataMatriz.Clone();


            for (int i = 0; i < copyDataMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < copyDataMatriz.GetLength(1); j++)
                {
                    //PROBLEMA PARA REGRESAR LOS NUMBERS ASCII A TEXT ORIGINAL

                    // Calcular el módulo inverso de x
                    //int modInv = 0;
                    //for (int i = 1; i < 33; i++)
                    //{
                    //    if (((x % 33) * (i % 33)) % 33 == 1)
                    //    {
                    //        modInv = i;
                    //        break;
                    //    }
                    //}

                    //copyDataMatriz[i, j] = ((copyDataMatriz[i, j] * x) % 33) + 96;
                    //* InversoModular(x, 33)
                    copyDataMatriz[i, j] = ((copyDataMatriz[i, j]-96));
                }
            }
            Console.WriteLine("Matriz de valores entre 0 y 32 bytes\n");
            // Imprimir la matriz resultante
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

        public static int InversoModular(int a, int m)
        {
            int m0 = m, t, q;
            int x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        public int[,] byteToMrtz(byte[] bytePrueba, string clave)
        {
            int size = (int)Math.Sqrt(bytePrueba.Length);
            int[,] matriz = new int[size, size];
            int x = alfaEncrypt(clave);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int index = i * size + j;
                    if (index < bytePrueba.Length)
                    {
                        matriz[i, j] = bytePrueba[index];
                    }
                    else
                    {
                        matriz[i, j] = 0; // Opcionalmente puedes rellenar con un valor por defecto
                    }
                }
            }
            Console.WriteLine("devolviendo a valores ascii numbers el texto encriptado");
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


        public int alfaEncrypt(string clave)
        {
            keyMatriz = matrizVignere(this.key);
            //Ahora lo que queremos hacer es hallar el valor absoluto del determinante de la matriz de key
            int absDetMatrz = Math.Abs(DeterminanteGauss1(keyMatriz));
            int alfa = absDetMatrz + clave.Length;
            return Math.Abs(alfa);
        }

        public static int DeterminanteGauss1(int[,] matriz)
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

            //Console.WriteLine("Matrizes de Vigenere");

            //// Imprimir matriz 
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            return matriz;
        }
    }
}
