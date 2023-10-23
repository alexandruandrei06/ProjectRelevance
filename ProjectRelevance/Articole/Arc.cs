namespace ProjectRelevance;
/*
 * Clasa pentru obiectul Arc care mostesneste clasa ArticolInventar, apeland constructorul cu greutatea prestabilita
 * greutate = 1
 * volum = 4
 */
public class Arc : ArticolInventar
{
    public Arc() : base(1f, 4f)
    {
    }
}