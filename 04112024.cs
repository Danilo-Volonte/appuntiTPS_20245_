using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lezione04112024
{
    internal class Program
    {
        static Thread t1, t2, t3;
        static ConcurrentQueue<int> coda; //risolve il problemma della lista in cui vengono messi dei nuovi elemnti contemporaneamemnte
        static Random rnd;
        static int cont;
        static int totale;
        static int n;
        static void Main(string[] args)
        {
            coda = new ConcurrentQueue<int> ();
            cont = 0;
            totale = 0;
            t1 = new Thread(numeroCasuale);
            t2 = new Thread(numeroCasuale);
            t3 = new Thread(stampa);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }

        private static void numeroCasuale()
        {
            //int casuale = Random.Next();
            for(int i = 0; i < 1000; i++)
            {
                coda.Enqueue(i); //mette il numero in coda (e forse stampa)
                Thread.Sleep(40);
            }
        }

        private static void stampa()
        {
            if (cont < 1000)
            {
                if(coda.TryDequeue(out n))
                {
                    cont++;
                    totale += n;
                    Console.WriteLine($"Media numeri: {(double)totale/cont}");
                }
                else
                {
                    Thread.Sleep(20);
                }
            }
        }

    }
}
