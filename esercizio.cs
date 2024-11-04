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
        List<string> trentaPerCento = new List<string> { "macchina", "macchina", "macchina", "macchina", "macchina", "macchna", "macchina", "camion", "camion", "camiom" }; //liste per fare i mdo che in un casello ci sia la probabilità del 30% che ci sia un ccamion
        static List<string> coda; //da cosa è composta la coda al casello
        static Thread t1, t2, t3;
        static Random rnd;
        static int sommaComplessiva; //sooma di tutto quello che abbiamo guadaganto da mettere a fine programma
        static void Main(string[] args)
        {
            t1 = new Thread(numeroCasuale);
            t2 = new Thread(numeroCasuale);
            t3 = new Thread(infinitoCoda);
        }
        private void infinitoCoda()
        {
            bool avanti = false;
            while (avanti) //va all'infinito
            {
                int lunghezza=0;
                foreach(string i in coda)
                {
                    lunghezza++;
                }
                if (lunghezza <= 20)
                {
                    coda.Add(); //TODO cerca come prendere un elemnto casuale da una lista e mettilo qua}
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }

        private void togliVetture()
        {
            bool avanti = false;
            if(avanti)
            {
                Thread.Sleep(100);
                coda.Remove(coda[ -1]);
            }
        }


       
    }
}
