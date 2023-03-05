using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2EDA_AlgoritmoEncriptacion.Logica
{
    public class Decrypt
    {
        int[] dataEncrypt;
        byte[] key;
        int[,] keyMatriz;
        public Decrypt(string msgEncrypt, string clave)
        {
            Console.WriteLine("DESENCRIPTANDO");

            int[] intArray = new int[msgEncrypt.Length];

            for (int i = 0; i < msgEncrypt.Length; i++)
            {
                intArray[i] = (int)msgEncrypt[i];
            }

            dataEncrypt= (int[])intArray.Clone();

            this.key = Encoding.UTF8.GetBytes(clave);
            
        }

        public String mensajeUsuario(String clave)
        {
            string mensajeUser = cadenaOriginal(desencriptarMensajeNUM(byteToMrtz(dataEncrypt, clave), clave));
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(mensajeUser);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            string mensajeUNICODE = Encoding.Unicode.GetString(unicodeBytes);
            String nuevaCadenaSinSimbolosRaros = "";
            for (int i = 0; i < mensajeUNICODE.Length; i++)
            {
                if (i % 2 == 0) // Si el índice es par
                {
                    nuevaCadenaSinSimbolosRaros += mensajeUNICODE[i];
                }
            }
            return nuevaCadenaSinSimbolosRaros;
        }

        public string cadenaOriginal(int[,] matrizOriginal)
        {
            string mensajeDesencriptado = "";

            int[] primeraFila = new int[matrizOriginal.GetLength(1)];

            for (int i = 0; i < matrizOriginal.GetLength(1); i++)
            {
                primeraFila[i] = matrizOriginal[0, i];
            }

            for (int i = 0; i < primeraFila.GetLength(0); i++)
            {
                    char c = (char)primeraFila[i];
                    mensajeDesencriptado += c;
            }
            Console.WriteLine("\n\n");

            Console.WriteLine(mensajeDesencriptado);
            return mensajeDesencriptado;
        }

        public int[,] desencriptarMensajeNUM(int[,] matrizCodificada, string clave)
        {
            int x = alfa(clave);
            int[,] copyDataMatriz = matrizCodificada;

            // Multiplicar la matriz por el inverso de la funcion
            for (int i = 0; i < copyDataMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < copyDataMatriz.GetLength(1); j++)
                {
                    copyDataMatriz[i, j] = ((copyDataMatriz[i, j] + (clave.Length * x)) / x);
                }
            }
            Console.WriteLine("Matriz de numeros Originales\n");

            for (int i = 0; i < copyDataMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < copyDataMatriz.GetLength(1); j++)
                {
                    Console.Write(copyDataMatriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            return copyDataMatriz;
        }

        public int[,] byteToMrtz(int[] intPrueba, string clave)
        {
            int size = (int)Math.Sqrt(intPrueba.Length);
            int[,] matriz = new int[size, size];
            int x = alfa(clave);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int index = i * size + j;
                    if (index < intPrueba.Length)
                    {
                        matriz[i, j] = intPrueba[index];
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
        public int alfa(string clave)
        {
            //Pasamos el arreglo de bytes a una matriz

            keyMatriz = matrizVignere(this.key);

            //Ahora lo que queremos hacer es hallar el valor absoluto del determinante de la matriz de key
            int absDetMatrz = Math.Abs(DeterminanteGauss1(keyMatriz));
            int alfa = absDetMatrz + clave.Length;
            Console.WriteLine(alfa);
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
            return matriz;
        }

        public int[,] matrizVignere(int[] utfBytes)
        {
            int size = utfBytes.Length;
            int[,] matriz = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matriz[i, j] = utfBytes[(i + j) % size];
                }
            }
            return matriz;
        }
    }
}
