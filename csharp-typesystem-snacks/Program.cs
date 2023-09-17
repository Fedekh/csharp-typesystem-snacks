using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
 * Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
 * Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
 * Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
 * Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
 * Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
 * Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
 * Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
 * Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
 * Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
 * Bonnus: Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire. Una volta la scelta il programma esegue il snack corrispondente.
*/
namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            bool isInvalid = true;
            while (isInvalid)
            {
                Console.WriteLine("Inserisci 2 numeri interi : ");
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2))
                {
                    if (num1 > num2)
                    {
                        Console.WriteLine($"Il maggiore tra i 2 è il primo, ovvero : {num1} ");
                    }
                    else
                    {
                        Console.WriteLine($"Il maggiore tra i 2 è il secondo, ovvero: {num2}");
                    }
                    Console.ReadLine();
                    isInvalid = false;
                }
                else
                {
                    Console.WriteLine("Devi inserire 2 numeri interi : ");

                }

            }




            //2
            bool isInvalid2 = true;
            while (isInvalid2)
            {

                Console.WriteLine("Inserisci 2 stringhe:");
                string c = Console.ReadLine();
                string d = Console.ReadLine();

                if (!int.TryParse(c, out _) && !int.TryParse(d, out _) || (string.IsNullOrEmpty(c) && string.IsNullOrEmpty(d)))
                {

                    if(c.Length > d.Length)
                    {
                        Console.WriteLine($"La stringa piu lunga è la prima cioe : {c}");
                    }
                    else if (c.Length == d.Length)
                    {
                        Console.WriteLine($"Le due stringhe sono lunghe uguali, cioe {d.Length} caratteri");

                    }
                    else
                    {
                        Console.WriteLine($"La stringa piu lunga è la seconda cioe : {d}");
                        
                    }
                    isInvalid2 = false;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("DEVI INSERIRE 2 stringhe:");

                }

            }

        }
    }
}
