using System;
using System.Collections.Generic;
using System.Linq;

namespace ArvoreCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(3);
            numeros.Add(2);
            numeros.Add(1);
            numeros.Add(6);
            numeros.Add(0);
            numeros.Add(5);

            GeraArvore(numeros);


            Console.WriteLine("Pressione qualquer tecla para gerar a segunda árvore");
            Console.ReadLine();
            Console.Clear();

            numeros.Clear();
            numeros.Add(7);
            numeros.Add(5);
            numeros.Add(13);
            numeros.Add(9);
            numeros.Add(1);
            numeros.Add(6);
            numeros.Add(4);

            GeraArvore(numeros);

        }

        private static void GeraArvore(List<int> numeros)
        {
            List<int> esquerda = new List<int>();
            List<int> direita = new List<int>();

            int raiz;

            raiz = numeros.Max();

            Console.WriteLine("Array de entrada:");
            Console.WriteLine("[" + String.Join(", ", numeros) + "]");



            Console.WriteLine("\r\nRaiz: " + raiz.ToString());

            bool chegou = false;

            foreach (int numero in numeros)
            {
                if (numero == raiz)
                {
                    chegou = true;
                    continue;
                }

                if (!chegou)
                    esquerda.Add(numero);
                else
                    direita.Add(numero);

            }

            Console.WriteLine("\r\nGalhos da Esquerda:");
            Console.WriteLine("[" + String.Join(", ", esquerda.OrderByDescending(x => x).ToList()) + "]");
            Console.WriteLine("\r\nGalhos da Direita:");
            Console.WriteLine("[" + String.Join(", ", direita.OrderByDescending(x => x).ToList()) + "]");

        }
    }
}
