namespace ProjectRelevance;
/*
 * Clasa pentru obiectul Mancare care mostesneste clasa ArticolInventar, apeland constructorul cu greutatea prestabilita
 * greutate = 1
 * volum = 0.5
 */
public class Mancare : ArticolInventar
{
    public Mancare() : base(1f, 0.5f)
    {
    }
}