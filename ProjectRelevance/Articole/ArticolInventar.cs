namespace ProjectRelevance;
/*
 *  Aceasta clasa este o clasa care defineste atributele comune pe care un obiect le are 
 */
public class ArticolInventar
{
    public float weight // greutatea unui obiect
    {
        get;
        // get method
        set;
        // set method
    }

    public float volume // volumul unui obiect
    {
        get;
        // get method
        set;
        // set method
    }
    
    /*
     * Contructor care initializeaza atributele unui articol
     */
    public ArticolInventar(float weight, float volume)
    {
        this.weight = weight;
        this.volume = volume;
    }


}