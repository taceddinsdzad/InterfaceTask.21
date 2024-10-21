
public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract string Surname { get; set; }
    public override string ToString()
    {
        return $"{Name} {Surname}";
    }
}
