namespace lab_3;

enum Gender
{
    Male,
    Female,
    Other
}

struct Person
{
    public string Name;
    public Gender Gender;
    public int Age;

    public override string ToString()
    {
        return $"Name: {Name}, Gender: {Gender}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person()
        {
            Name = "Jitu",
            Gender = Gender.Male,
            Age = 32
        };

        Console.WriteLine(person);
    }
}
