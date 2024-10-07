using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

int numero0;
int numero1;
int numero2;    
int numero3;
 // esercizo guarda teams

namespace esercizio11
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static Thread t3;
        static void Main(string[] args) //il main è un thread
        {
            t1 = new Thread(primoCompreso);
            t1.Name = "Thread 1";
            t2 = new Thread(secondoCompreso);
            t2.Name = "Thread 2";
            t3 = new Thread(terzoCompreso);
            t3.Name = "Thread 2";

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
        private static primoCompreso(string[] args)
        {
            numero1=new Random();
        }
    }
}
