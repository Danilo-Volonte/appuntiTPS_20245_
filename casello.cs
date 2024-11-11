using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casello
{
    internal class Casello
    {
        static int massimo = 150; //numero massimo di veicoli che possono atttraversare il cancello
        static List<string> trentaPerCento = new List<string> { "macchina", "macchina", "macchina", "macchina", "macchina", "macchna", "macchina", "camion", "camion", "camiom" }; //liste per fare i mdo che in un casello ci sia la probabilità del 30% che ci sia un ccamion
        static List<string> coda; //da cosa è composta la coda al casello
        static Thread t1, t2,t3;
        static Random rnd;
        static int sommaComplessiva;
        //sooma di tutto quello che abbiamo guadaganto da mettere a fine programma
        static void Main(string[] args)
        {
            t1 = new Thread(infinitoCoda);
            t2 = new Thread(togliVetture);
            t3 = new Thread(stampa);
            Console.ReadKey();
        }

      
        static private void infinitoCoda()
        {
            bool avanti = false;
            while (avanti == false) 
            {
                Console.Write("vuoi continuare");
                string sino = Console.ReadLine();
                if (sino == "no")
                {
                    avanti = true;
                }
                else
                {
                    int lunghezza = coda.Count;
                    if (lunghezza <= 20)
                    {
                        string uscita = trentaPerCento[rnd.Next(trentaPerCento.Count)];
                        coda.Add(uscita); //TODO cerca come prendere un elemnto casuale da una lista e mettilo qua
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
            }
        }

        static private void togliVetture()
        {
            bool avanti = false;
            if(avanti)
            {
                Thread.Sleep(100);
                coda.Remove(coda[ -1]);
                sommaComplessiva += rnd.Next(2,70);
            }
        }

        static private void   stampa()
        {
            Console.WriteLine($"tutto:{sommaComplessiva}");
        }
       
    }
}