
using System.Text.RegularExpressions;

public class Student
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }

    private static int count = 0;

    public Student(string name, string surname)
    {
        if (!CheckName(name) || !CheckName(surname))
        {
            throw new ArgumentException("Name və surname 3-25 simvol olmalıdır");
        }

        Id = ++count;
        Name = name;
        Surname = surname;
    }

    public static bool CheckName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Za-z]{3,25}$");
    }


    public override string ToString()
    {
        return $"{Name} {Surname} (ID: {Id})";
    }
}
