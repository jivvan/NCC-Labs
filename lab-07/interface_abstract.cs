namespace lab_1;

interface IAnimal
{
    void MakeSound();
    void Locomote();
}

abstract class Animal
{
    public abstract void MakeSound();
    public virtual void Locomote()
    {
        Console.WriteLine("Tuk Tuk");
    }
}

class Horse : Animal, IAnimal
{
    public string name, owner;
    public Horse(string name, string owner)
    {
        this.name = name;
        this.owner = owner;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Neigh!!!");

    }
    public override void Locomote()
    {
        Console.WriteLine("Tugduk!!! Tugduk!!!");
    }
}

class InterfaceAbstract
{
    static void Main(string[] args)
    {
        Horse h = new Horse("Harry", "Ron");
        h.MakeSound();
        h.Locomote();
    }
}
