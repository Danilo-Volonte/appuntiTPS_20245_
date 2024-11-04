using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lezione04112024
{
    internal class Program
    {
        static Thread t1, t2;
        static List<int> lista;
        static void Main(string[] args)
        {
            lista = new List<int>();
            t1 = new Thread(salvaN);
            t2 = new Thread(salvaN2);
        }

        private static void salvaN()
        {
            for(int i = 1; i <= 10000; i++)
            {
                lista.Add(i);
            }
        }
         //in questo modo i due possono acccedere alla lista contemporaneamente e questo crea degli errori
        private static void salvaN2()
        {
            for (int i = 1; i <= 10000; i++)
            {
                lista.Add(i);
            }
        }
    }
}
