using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rifareVerifica2
{
    internal class Program
    {
        public static List<int> coda = new List<int>();
        public static Random rnd = new Random();
        public static Dictionary<int, int> quantiNumeri = new Dictionary<int, int> { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 } };
        public static Thread t1, t2;
        static void produttore()
        {
            for (int i = 0; i < 200; i++)
            {
                if(i%50==0)
                {
                    Thread.Sleep(1000);
                }
                int numero = rnd.Next(10);
                coda.Add(numero);
                Console.WriteLine($"numero{numero} : posizione {i}");
                Thread.Sleep(50);
            }

        }

        static void consumatore()
        {
            Console.WriteLine("f");
            int tutto = 0;
            foreach(int i in coda)
            {
                tutto+= i;
                quantiNumeri[i]++;
            }
            int contatore = 0;
            List<int> tutti = new List<int> { quantiNumeri[1], quantiNumeri[2], quantiNumeri[3], quantiNumeri[5], quantiNumeri[6], quantiNumeri[7], quantiNumeri[8], quantiNumeri[9], quantiNumeri[10] };
            for(int i = 0; i<=3; i++) //inizio primi 3
            {
                contatore++;
                int maggiore = tutti.Max();
                if (quantiNumeri[1]==maggiore)
                {
                    Console.WriteLine($"{i}° : {1} == {quantiNumeri[1]}");
                    tutti.Remove(quantiNumeri[1]);
                }
                else if (quantiNumeri[2] == maggiore)
                {
                    Console.WriteLine($"{i}° : {2} == {quantiNumeri[2]}");
                    tutti.Remove(quantiNumeri[2]);
                }
                else if (quantiNumeri[3] == maggiore)
                {
                    Console.WriteLine($"{i}° : {3} == {quantiNumeri[3]}");
                    tutti.Remove(quantiNumeri[3]);
                }
                else if (quantiNumeri[4] == maggiore)
                {
                    Console.WriteLine($"{i}° : {4} == {quantiNumeri[4]}");
                    tutti.Remove(quantiNumeri[4]);
                }
                else if (quantiNumeri[5] == maggiore)
                {
                    Console.WriteLine($"{i}° : {5} == {quantiNumeri[5]}");
                    tutti.Remove(quantiNumeri[5]);
                }
                else if (quantiNumeri[6] == maggiore)
                {
                    Console.WriteLine($"{i}° : {6} == {quantiNumeri[6]}");
                    tutti.Remove(quantiNumeri[6]);
                }
                else if (quantiNumeri[7] == maggiore)
                {
                    Console.WriteLine($"{i}° : {7} == {quantiNumeri[7]}");
                    tutti.Remove(quantiNumeri[7]);
                }
                else if (quantiNumeri[8] == maggiore)
                {
                    Console.WriteLine($"{i}° : {8} == {quantiNumeri[8]}");
                    tutti.Remove(quantiNumeri[8]);
                }
                else if (quantiNumeri[9] == maggiore)
                {
                    Console.WriteLine($"{i}° : {9} == {quantiNumeri[9]}");
                    tutti.Remove(quantiNumeri[9]);

                }
                if (quantiNumeri[10] == maggiore)
                {
                    Console.WriteLine($"{i}° : {10} == {quantiNumeri[10]}");
                    tutti.Remove(quantiNumeri[10]);

                }
            }
        }



        static void Main(string[] args)
        {
            t1 = new Thread(produttore);
            t2 = new Thread(consumatore);

            t1.Start();
            t1.Join();
            t2.Start();
            Console.ReadKey();
        }
    }
}
