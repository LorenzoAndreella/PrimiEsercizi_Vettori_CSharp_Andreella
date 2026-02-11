using System;
using static System.Console;

namespace Es1Vettore
{
    class Program
    {
        static void Main(string[] args)
        {

            bool x;
            int n;
            do
            {
               WriteLine("Inserisci quanti elementi vuoi inserire nel vettore"); 
               x = int.TryParse(ReadLine(), out n);
                if (!x)
                {
                    WriteLine("Input non valido, inserisci un numero intero.");
                }
            } while (!x);

            int[] vett = new int[n];                //creazione del vettore con dimensione n

            for (int i = 0; i < vett.Length; i++)
            {
                do
                {
                    WriteLine("Inserisci un numero");
                    x = int.TryParse(ReadLine(), out vett[i]);
                    if (!x)
                    {
                        WriteLine("Input non valido, inserisci un numero intero.");
                    } 
                } while (!x);
            }

            int valido = 1;         //variabile che indica se il vettore è valido (1) o non valido (0)
            for (int i=0; i < vett.Length; i++)
            {
                for (int j = i+1; j < vett.Length; j++)
                {
                  if (vett[i] == vett[j])               //se si trova un elemento uguale a un altro, il vettore non è valido
                    {
                        valido = 0;
                        break;
                    }
                }
            }

            WriteLine(valido);          //stampa 1 se il vettore è valido, 0 se non è valido
        }
    }
}
