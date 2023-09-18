using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Console.WriteLine("Scegli uno degli snack (1-10) o premi 0 per uscire:");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice) 
                {
                        case 0:
                        Console.WriteLine("Arrivederci!");return;

                        case 1:
                        Snack1();break;

                        case 2:
                        Snack2(); break;

                        case 3:
                        Snack3(); break;

                        case 4:
                        Snack4(); break;

                        case 5:
                        Snack5(); break;

                        case 6:
                        Snack6(); break;

                        case 7:
                        Snack7(); break;

                        case 8:
                        Snack8(); break;

                        case 9:
                        Snack9(); break;

                        case 10:
                        Snack10(); break;
                }

            }

            void Snack1() 
            { 
                Console.WriteLine("Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.");
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
                        else if (num1 == num2)
                        {
                            Console.WriteLine("I numeri sono uguali");
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

            }

            void Snack2()
            {
                Console.WriteLine("Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.");
                bool isInvalid2 = true;
                while (isInvalid2)
                {

                    Console.WriteLine("Inserisci 2 stringhe:");
                    string c = Console.ReadLine();
                    string d = Console.ReadLine();

                    if (!int.TryParse(c, out _) && !int.TryParse(d, out _) || (string.IsNullOrEmpty(c) && string.IsNullOrEmpty(d)))
                    {

                        if (c.Length > d.Length)
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
            
            void Snack3()
            {
                Console.WriteLine("* Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.");

                int somma = 0;
                int i = 0;
                bool isValid = true;

                while (i < 10 && isValid)
                {
                    string f = Console.ReadLine();
                    if (int.TryParse(f, out int num1))
                    {
                        somma += num1;
                        i++;
                        if (i == 10)
                        {
                            Console.WriteLine($"La somma dei tuoi 10 numeri è : {somma}");
                            Console.ReadLine();
                            isValid = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("DEVI INSERIRE un numero intero:");
                    }

                }
            }
           
            void Snack4()
            {

                //4
                Console.WriteLine("Snack 4: Calcola la somma e la media dei numeri da 2 a 10.");

                int somma1 = 0;

                for (int j = 2; j < 11; j++)
                {
                    somma1 += j;

                }

                Console.WriteLine($"La somma dei numeri è {somma1}");
                Console.WriteLine($"La media dei numeri è {somma1 / 8}");
                Console.ReadLine();
            }

            void Snack5()
            {
                //5
                Console.WriteLine("Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");

                bool isInvalid3 = true;
                while (isInvalid3)
                {
                    Console.WriteLine("Scrivi un numero intero:");
                    string num3 = Console.ReadLine();
                    if (int.TryParse(num3, out int num33))
                    {
                        if (num33 % 2 == 0)
                        {
                            Console.WriteLine($"Il numero scelto è pari ed è  {num33}");
                        }
                        else
                        {
                            Console.WriteLine($"Il numero scelto è dispari, il successivo è {num33 + 1}");
                        }
                        Console.WriteLine("Premi un tasto per chiudere...");
                        Console.ReadLine();

                        isInvalid3 = false;
                    }
                    else
                    {
                        Console.WriteLine("DEVI INSERIRE un numero intero:");

                    }

                }
            }

           
            void Snack6()
            {
                //6

                Console.WriteLine("Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");
                string[] nomiItaliani = new string[]
                {
                    "Mario",
                    "Luigi",
                    "Giovanni",
                    "Paolo",
                    "Francesca",
                    "Giulia",
                    "Elena",
                    "Antonio",
                    "Marco",
                    "Lorenzo"
                };

                Console.WriteLine("Come ti chiami ?");

                string nome = Console.ReadLine();

                if (nomiItaliani.Contains(nome))
                {
                    Console.WriteLine("Prego puoi entrare");
                }
                else { Console.WriteLine("Non sei invitato");

                }
                Console.ReadLine();
            }

            void Snack7()
            {
                //7
                Console.WriteLine("Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");

                List<int> list = new List<int>() { };
                for (int kk = 0; kk < 6; kk++)
                {
                    Console.WriteLine("Inserisci un numero");
                    string k = Console.ReadLine();
                    if (int.TryParse(k, out int kkk)) 
                    {
                        if (kkk % 2 != 0) 
                        {
                            list.Add(kkk);
                        }
                    }

                }

                Console.WriteLine($"Numeri dispari inseriti nell'array sono {list.Count}:");
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

            void Snack8()
            {
                //8
                Console.WriteLine("Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");

                int[] numeri = { 24, 58, 12, 36, 42, 89, 7, 63, 18, 51, 77, 95 };
                int somaa = 0;

                for (int j = 1; j < numeri.Length; j+=2)
                {
                    somaa += numeri[j];
                
                }

                Console.WriteLine($"La somma dei numeri dispari è : {somaa}");
                Console.ReadLine();

            }

            void Snack9()
            {
                //9
                Console.WriteLine("Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.");


                List<int> list1 = new List<int>() { };
                int sommaIndici = 0;
                for (int kk = 0; sommaIndici <= 50; kk++)
                {
                    Console.WriteLine("Inserisci un numero");
                    string k = Console.ReadLine();
                    if (int.TryParse(k, out int kkk))
                    {
                           list1.Add(kkk);
                    
                    }
                    sommaIndici += list1[kk];

                }
                Console.WriteLine($"Il tuo è array è formato da {list1.Count} elementi");
                foreach (int item in list1)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();

            }

            void Snack10()
            {
                //10
                Console.WriteLine("Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.");

                int N = 0;
                bool isValidInput = false;
                Random random = new Random();

                while (!isValidInput)
                {
                    Console.WriteLine("Inserisci un numero:");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out N) && N > 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Inserisci un numero valido (maggiore di zero).");
                    }
                }

                for (int ii = 0; ii < N; ii++)
                {
                    List<int> arrayNuovo = new List<int>();

                    for (int j = 0; j < 10; j++)
                    {
                        int randomNumber = random.Next(1, 101); // Genera numeri casuali tra 1 e 100
                        arrayNuovo.Add(randomNumber);
                    }

                    Console.WriteLine($"Il tuo array è formato da {arrayNuovo.Count} elementi:");
                    foreach (int item in arrayNuovo)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.ReadLine();

            }

        }
    }
}
