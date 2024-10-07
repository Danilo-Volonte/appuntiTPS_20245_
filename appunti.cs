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
        static void Main(string[] args) //il main è un thread
        {

            Thread t1 = new Thread(stampaNumeriDispari); //crea nuovo thread
            Thread t2 = new Thread(stampaNumeriPari);
            
            t1.Start(); //per iniziare un thread
            t2.Start(); //durante l'sesecuzione del primo thread parte anche il secondo facendo in modo che uno finsca prima dell'obbiettivo 
            Console.ReadKey(); //fa in modo che il programma non chiuda finché non hai schiacciato un qualsiasi pulsante 
        }

        private static void stampaNumeriPari()
        {
            for (int i = 0; i < 100; i = i + 2)
            {
                Console.WriteLine("numero " + i);
            }
        }

        private static void stampaNumeri()
        {
            for(int i=1; i<=200;i++) 
            {
                Console.WriteLine(i);
            }
        } //ottimizzazione delle risorse --> avendom messo tutto dentro una funzione se questa non vine usata allora questa non utilizza spazio inutile 

        private static void stampaNumeriDispari()
        {
            for (int i = 1; i < 100; i = i + 2)
            {
                Console.WriteLine("numeros " + i);
            }
        }





    }
}
