// See https://aka.ms/new-console-template for more information

using ProjectRelevance;

// Variabile folosite pe parcursul programului
int maxItemsNumber;
float maxWeight, maxVolume;
char command;
bool exit = false;

// Obiectul ajutator pentru meniul interactiv al aplicatiei
ConsoleHelper interactiveConsole = new ConsoleHelper();

// Citirea si initializarea ghiozdanului cu limitele acestuia
Console.WriteLine("Introduceti limitele ghiozdanului:");
Console.Write("Numarul maxim de articole admise: ");
maxItemsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Greutatea maxima admisa: ");
maxWeight =  float.Parse(Console.ReadLine());
Console.Write("Volumul maxim admis: ");
maxVolume =  float.Parse(Console.ReadLine());

Ghiozdan ghiozdan = new Ghiozdan(maxVolume, maxWeight, maxItemsNumber);

Console.Clear();
ghiozdan.printLimits();

while(!exit) {
    interactiveConsole.printMenu();
    Console.Write("Comanda = ");
    command = Console.ReadLine().ToUpper()[0];
    Console.Clear();
    switch (command)
    {
        //Adaugarea unui obiect in ghiozdan
        case 'A':
            interactiveConsole.printAddOption();
            string obiect = Console.ReadLine().ToLower().Replace("\n", "");
            switch (obiect)
            {
                case "sageata":
                    if (ghiozdan.Adauga(new Sageata()))
                    {
                        Console.WriteLine("S-a adaugat o Sageata.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
                case "arc":
                    if (ghiozdan.Adauga(new Arc()))
                    {
                        Console.WriteLine("S-a adaugat un Arc.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
                case "franghie":
                    if (ghiozdan.Adauga(new Franghie()))
                    {
                        Console.WriteLine("S-a adaugat o Franghie.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
                case "apa":
                    if (ghiozdan.Adauga(new Apa()))
                    {
                        Console.WriteLine("S-a adaugat o Apa.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
                case "mancare":
                    if (ghiozdan.Adauga(new Mancare()))
                    {
                        Console.WriteLine("S-a adaugat Mancare.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
                case "sabie":
                    if (ghiozdan.Adauga(new Sabie()))
                    {
                        Console.WriteLine("S-a adaugat o Sabie.");
                    }
                    else
                    {
                        Console.WriteLine("Nu se poate adauga deoarece una din cele 3 limite este depasita.");
                    }
                    break;
            }
            break;
        //Afisarea limitelor ghiozdanului
        case 'L':
            ghiozdan.printLimits();
            break;
        //Afisarea continutului ghiozdanului
        case 'C':
            ghiozdan.printItems();
            break;
        //Afisarea articolelor posibile
        case 'E':
            interactiveConsole.printPosibleElements();
            break;
        //Terminarea programului
        case 'X':
            exit = true;
            break;
         default :
             Console.WriteLine("Aceasta operatie nu exista.");
            break;
    }
}

