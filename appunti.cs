using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

namespace esercizio11
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args) //il main è un thread
        {
                Thread.CurrentThread.Name = "Main"; //stiamo assegnando al thread del Main il nome main
                
                t1 = new Thread(saluta);
                t1.Name = "Thread 1";
                t2 = new Thread(saluta);
                t2.Name = "Thread 2";

                t1.Start();
                t2.Start();
                Console.ReadKey();
            }
        private static void saluta() 
            {
                Console.WriteLine(Thread.CurrentThread.Name+" sono partito ");
                Console.WriteLine($"{Thread.CurrentThread.Name}. il mio ID è {Thread.CurrentThread.ManagedThreadId} ");
                Console.WriteLine(Thread.CurrentThread.Name + " si va a letto!"); //per addormentare il Thread
                Thread.Sleep(120); //dormo per 120 ms
                Console.WriteLine(Thread.CurrentThread.Name + " sono tornato ragazzi!");
            }
        }
    }

