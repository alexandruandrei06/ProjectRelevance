namespace ProjectRelevance;
/*
 * Clasa pentru obiectul Sageata care mostesneste clasa ArticolInventar, apeland constructorul cu greutatea prestabilita
 * greutate = 0.1
 * volum = 0.05
 */
public class Sageata : ArticolInventar
{
    public Sageata() : base(0.1f, 0.05f)
    {
    }
}