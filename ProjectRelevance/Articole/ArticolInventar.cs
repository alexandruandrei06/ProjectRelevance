namespace ProjectRelevance;

public class ArticolInventar
{
    public float weight // property
    {
        get;
        // get method
        set;
        // set method
    }

    public float volume // property
    {
        get;
        // get method
        set;
        // set method
    }
    
    public ArticolInventar(float weight, float volume)
    {
        this.weight = weight;
        this.volume = volume;
    }


}