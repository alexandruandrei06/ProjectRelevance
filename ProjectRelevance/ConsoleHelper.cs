namespace ProjectRelevance;

public class ConsoleHelper
{
    public void printMenu()
    {
        Console.WriteLine("\nCe operatie doriti sa efectuati mai departe? " +
                          "Alegeti o optiune din meniul de mai jos tastand litera din paranteza");
        Console.WriteLine("[A/a] - Adauga un nou articol in ghiozdan");
        Console.WriteLine("[L/l] - Afisare limite ghiozdan");
        Console.WriteLine("[C/c] - Afisare continut ghiozdan");
        Console.WriteLine("[E/e] - Afisare lista cu elemente posibile");
        Console.WriteLine("[X/x] - Terminare program");
    }

    public void printPosibleElements()
    {
        Console.WriteLine("Sageata -> greutate:0.1 & volum:0.05");
        Console.WriteLine("Arc     -> greutate:1 & volum:4");
        Console.WriteLine("Franghie-> greutate:1 & volum:1.5");
        Console.WriteLine("Apa     -> greutate:2 & volum:3");
        Console.WriteLine("Mancare -> greutate:1 & volum:0.5");
        Console.WriteLine("Sabie   -> greutate:5 & volum:3");
    }

    public void printAddOption()
    {
        Console.WriteLine("Pentru a adauga un obiect in ghiozdan, scrieti numele obiectului:");
        Console.WriteLine("Sageata, Arc, Franghie, Apa, Mancare, Sabie");
        Console.Write("Obiect = ");
    }
}