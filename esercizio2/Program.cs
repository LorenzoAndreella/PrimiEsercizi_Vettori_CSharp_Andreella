using System;
using static System.Console;

namespace Es2Vettore
{   
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[30];               //vettore di 30 elementi
            Random rand = new Random();             
            for (int i = 0; i < vett.Length; i++)
            {
                vett[i] = rand.Next(0, 101);            //numeri random da 0 a 100 (inclusi)
                Write(vett[i] + " ");
            }
            WriteLine();
            bool trovato = false;                   //variabile che indica se è stata trovata almeno una coppia di numeri tali che il primo sia il doppio dell'altro
            
            for (int i = 0; i < vett.Length; i++)       //ricerca coppie di numeri tali che il primo sia il doppio dell'altro
            {
                if (vett[i] % 2 == 0 && vett[i] != 0)               // può essere doppio solo se è pari e non nullo
                {
                    for (int j = 0; j < vett.Length; j++)
                    {
                        if (i != j && vett[i] == vett[j] * 2)               //se si trova una coppia, si stampa e si esce dal ciclo
                        {
                            Write($" / {vett[i]} {vett[j]}");
                            trovato = true;                     //trovata la coppia e si esce dal ciclo
                            break;                                      
                        }
                        
                    }
                }
            }
            if (!trovato)              //se non è stata trovata nessuna coppia, si stampa un messaggio
            {
                WriteLine("Non sono state trovate coppie di numeri tali che il primo sia il doppio dell'altro.");
            }
        }
    }
}