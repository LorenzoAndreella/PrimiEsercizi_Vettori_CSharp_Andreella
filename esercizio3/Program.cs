using System;
using static System.Console;

namespace Es3Vettore        
{   
    class Program
    {
        static void Main(string[] args)
        {
            float[] vett = new float[100];          //vettore
            bool x;
            float somma = 0;
            int count = 0;

            for (int i = 0; i < 100 && somma < 50; i++)         //ciclo per inserire i numeri, finisce se si raggiunge la fine del vettore o se la somma supera 50
            {
                do
                {
                    WriteLine("Inserisci un numero");
                    x = float.TryParse(ReadLine(), out vett[i]);
                } 
                while (!x || vett[i] == 0);

                somma += vett[i];
                count++;
            }

            if (count < 3)
            {
                WriteLine("Non hai inserito almeno 3 numeri");
                return;
            }

            float primo = vett[0];
            bool valido = false;            //variabile per verificare se esistono valori validi

            for (int i = 1; i < count && !valido; i++)
            {
                for (int j = i + 1; j < count && !valido; j++)
                {
                    float primoN = vett[i];             //primo numero da confrontare
                    float secondoN = vett[j];           //secondo numero da confrontare
                    if (primoN / secondoN == primo)
                    {
                        valido = true;          //se il rapporto tra primoN e secondoN è uguale a primo, allora abbiamo trovato dei valori validi
                        WriteLine($"Il rapporto tra {primoN} e {secondoN} vale {primo}");
                    }
                    else if (primoN != 0 && secondoN / primoN == primo)
                    {
                        valido = true;
                        WriteLine($"Il rapporto tra {secondoN} e {primoN} vale {primo}");
                    }
                }
            }

            if (!valido)
            {
                WriteLine("Non esistono valori validi");
            }
        }
    }
}