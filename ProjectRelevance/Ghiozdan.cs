using System.Collections;
using System.Reflection.Metadata;

namespace ProjectRelevance;

public class Ghiozdan
{
    public float maxVolume // maxVolume property
    {
        get;  // get method for maxVolume
    }

    public float maxWeight // property
    {
        get;
        // get method
    }

    public int maxItemsNumber // property
    {
        get;
        // get method
    }
    
    public float currVolume // maxVolume property
    {
        get;  // get method for maxVolume
        set;
    }

    public float currWeight // property
    {
        get;
        // get method
        set;
    }

    public ArrayList itemBag
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

    public bool Adauga(ArticolInventar articol)
    {
        if (this.itemBag.Count < this.maxItemsNumber 
            && articol.weight + this.currWeight <= this.maxWeight
            && articol.volume + this.currVolume <= this.maxVolume)
        {
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

    public void printLimits()
    {
        Console.WriteLine("Limitele ghiozdanului:");
        Console.WriteLine("Numarul maxim de articole admise: " + this.maxItemsNumber);
        Console.WriteLine("Greutatea maxima admisa: " + this.maxWeight);
        Console.WriteLine("Volumul maxim admis: " + this.maxVolume);
    }

    public void printItems()
    {
        Console.WriteLine("Continutul ghiozdanului este:");
        Console.WriteLine("Numarul curent de articole: " + this.itemBag.Count);
        Console.WriteLine("Greutatea curenta: " + this.currWeight);
        Console.WriteLine("Volumul curent: " + this.currVolume);
    }
}