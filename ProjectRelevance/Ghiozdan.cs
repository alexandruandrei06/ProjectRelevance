using System.Collections;
using System.Reflection.Metadata;

namespace ProjectRelevance;

public class Ghiozdan
{
    public float maxVolume // volumul maxim pe care il poate cara ghiozdanul
    {
        get;  // get method for maxVolume
    }

    public float maxWeight // greutatea maxima pe care o poate care ghiozdanul
    {
        get;
        // get method for maxWeight
    }

    public int maxItemsNumber // numarul maxim de articole pe care le poate cara ghiozdanul
    {
        get;
        // get method for maxItemsNumber
    }
    
    public float currVolume // volumul curent care se afla in ghiozdan
    {
        get;  // get method for currVolume
        set;
    }

    public float currWeight // greutatea curenta care se afla in ghiozdan
    {
        get;
        // get method for currWeight
        set;
    }

    public ArrayList itemBag // O lista care contine toate obiectele adaugate in ghiozdan
    {
        get;
    }
    
    public Ghiozdan(float maxVolume, float maxWeight, int maxItemsNumber)
    {
        this.maxVolume = maxVolume;
        this.maxWeight = maxWeight;
        this.maxItemsNumber = maxItemsNumber;
        this.itemBag = new ArrayList();
        this.currVolume = 0;
        this.currWeight = 0;
    }
    
    /*
     * Aceasta functie verifica daca se poate adauga un articol in ghiozdan returnand daca actiunea a reusit sau nu
     */
    public bool Adauga(ArticolInventar articol)
    {
        //Verificare ca nu sunt depasite limitele ghiozdanului
        if (this.itemBag.Count < this.maxItemsNumber 
            && articol.weight + this.currWeight <= this.maxWeight
            && articol.volume + this.currVolume <= this.maxVolume)
        {
            //Adaugare element si update la starea ghiozdanului
            this.itemBag.Add(articol);
            this.currVolume += articol.volume;
            this.currWeight += articol.weight;
            return true;
        }
        else
        {
            return false;
        }
    }

    /*
     * Aceasta functie printeaza limitele ghiozdanului
     */
    public void printLimits()
    {
        Console.WriteLine("Limitele ghiozdanului:");
        Console.WriteLine("Numarul maxim de articole admise: " + this.maxItemsNumber);
        Console.WriteLine("Greutatea maxima admisa: " + this.maxWeight);
        Console.WriteLine("Volumul maxim admis: " + this.maxVolume);
    }

    /*
     * Aceasta functie printeaza starea curenta a ghiozdanului
     */
    public void printItems()
    {
        Console.WriteLine("Continutul ghiozdanului este:");
        Console.WriteLine("Numarul curent de articole: " + this.itemBag.Count);
        Console.WriteLine("Greutatea curenta: " + this.currWeight);
        Console.WriteLine("Volumul curent: " + this.currVolume);
    }
}