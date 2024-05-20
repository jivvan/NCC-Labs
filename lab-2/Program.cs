namespace lab_2;

class GrandFather
{
    public virtual void Greet()
    {
        Console.WriteLine("Hello, grandson!");
    }
    public void Introduction()
    {
        Console.WriteLine("I am your grandfather!");
    }
}

class Father : GrandFather
{
    public override void Greet()
    {
        Console.WriteLine("Hello, son!");
    }
    public new void Introduction()
    {
        Console.WriteLine("I am your father!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Father father = new Father();
        GrandFather grandFather = new GrandFather();
        grandFather.Greet();
        grandFather.Introduction();
        father.Greet();
        father.Introduction();
    }
}
