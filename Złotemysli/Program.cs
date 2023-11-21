using System;
using System.Collections.Generic;

class Program
{
    static List<string> ZloteMysli = new List<string>
    {
        "Wiek nie ma znaczenia, chyba że jesteś serem",
        "Jeżeli czegoś nie wolno, a bardzo się chce, to można.",
        "Życie to jest dobrze i źle. I tak jest dobrze. Bo jak jest tylko dobrze, to jest źle.",
        "Rób to, co możesz, tym, co posiadasz, i tam, gdzie jesteś.",
        "Nie wydawaj wyroku, zanim nie wysłuchasz przeciwnej strony."
    };
    static int aktualnyIndeks = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("           Menu          ");
            Console.WriteLine("1. Dodaj złotą myśl");
            Console.WriteLine("2. Edytuj złotą myśl");
            Console.WriteLine("3. Usuń złotą myśl");
            Console.WriteLine("4. Losuj złotą myśl");
            Console.WriteLine("5. Wyjście z programu");
            Console.Write("Wybierz opcję: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    DodajZlotaMysl();
                    break;
                case "2":
                    EdytujZlotaMysl();
                    break;
                case "3":
                    UsunZlotaMysl();
                    break;
                case "4":
                    LosujZlotaMysl();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    WyswietlNastepnaZlotaMysl();
                    break;
            }
        }
    }

    static void DodajZlotaMysl()
    {
        Console.Write("Wprowadź nową złotą myśl: ");
        string nowaMysl = Console.ReadLine();
        ZloteMysli.Add(nowaMysl);
        Console.WriteLine("Złota myśl została dodana.");
    }

    static void EdytujZlotaMysl()
    {
        Console.Write("Podaj numer złotej myśli do edycji (0 - {0}): ", ZloteMysli.Count - 1);
        if (int.TryParse(Console.ReadLine(), out int indeks) && indeks >= 0 && indeks < ZloteMysli.Count)
        {
            Console.Write("Wprowadź nową treść : ");
            ZloteMysli[indeks] = Console.ReadLine();
            Console.WriteLine("Myśl zaktualizowana.");
        }
        else
        {
            Console.WriteLine("Zle.");
        }
    }

    static void UsunZlotaMysl()
    {
        Console.Write("Podaj numer złotej myśli do usunięcia (0 - {0}): ", ZloteMysli.Count - 1);
        if (int.TryParse(Console.ReadLine(), out int indeks) && indeks >= 0 && indeks < ZloteMysli.Count)
        {
            ZloteMysli.RemoveAt(indeks);
            Console.WriteLine("Złota myśl została usunięta.");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer złotej myśli.");
        }
    }

    static void LosujZlotaMysl()
    {
        if (ZloteMysli.Count == 0)
        {
            Console.WriteLine("Brak złotych myśli do losowania.");
        }
        else
        {
            Random random = new Random();
            int losowyIndeks = random.Next(ZloteMysli.Count);
            string losowaMysl = ZloteMysli[losowyIndeks];
            Console.WriteLine("Losowa złota myśl: " + losowaMysl);
        }
    }

    static void WyswietlNastepnaZlotaMysl()
    {
        if (ZloteMysli.Count == 0)
        {
            Console.WriteLine("Niema złotych myśli.");
        }
        else
        {
            if (aktualnyIndeks >= ZloteMysli.Count)
            {
                aktualnyIndeks = 0;
            }
            Console.WriteLine("Następna złota myśl: " + ZloteMysli[aktualnyIndeks]);
            aktualnyIndeks++;
        }
    }
}
