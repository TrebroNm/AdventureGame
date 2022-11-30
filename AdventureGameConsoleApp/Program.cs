using AdventureGameClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        AdventureGame game = new AdventureGame();

        Console.WriteLine("Welcome to Adventure Game!");
        Console.WriteLine("Choose your character name:");

        string name = Console.ReadLine();
        game.Play(name);
    }
}