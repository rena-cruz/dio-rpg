using rpg.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Hero arus = new Hero("Arus", 42, "Knight");
        Ninja ninja = new Ninja("Wedge", 42, "Ninja");
        Wizard wizard = new Wizard("Jenica", 42, "White Wizard");
      
        Console.WriteLine(arus.Attack());
        Console.WriteLine(ninja.Attack());
        Console.WriteLine(wizard.Attack());
    }
}
