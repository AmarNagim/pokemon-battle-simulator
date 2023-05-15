// See https://aka.ms/new-console-template for more information
/*namespace PokemonBattleSimulator
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter name for your Charmander: ");
            string name = Console.ReadLine();

            Charmander Charmander = new Charmander(name, "fire", "weakness");

            battleCry(10);
        }

    }

    class Charmander
    {
        public String name;
        public String strength;
        public String weakness;

        public Charmander(String name, String strength, String weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;

        }

        public void battleCry(amountBattleCry)
        {
            for (int i = 0; i < amountBattleCry; i++)
            {
                Console.WriteLine(name + ': battlecry' + i);

            }


        }

    }

}*/

using System;

class Charmander
{
    private string name;
    private int fire;
    private int water;

    public Charmander(string name, int fire, int water)
    {
        this.name = name;
        this.fire = fire;
        this.water = water;
    }

    public string GetName()
    {
        return name;
    }

    public int GetFire()
    {
        return fire;
    }

    public int GetWater()
    {
        return water;
    }

    public void BattleCry()
    {
        Console.WriteLine(name + "!");
    }
}

class Program
{
    static void Main()
    {
        bool quitGame = false;

        while (!quitGame)
        {
            Console.WriteLine("=== Pokemon Battle Simulator ===");
            Console.WriteLine("1. Start the game");
            Console.WriteLine("2. Quit the game");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a name for your Charmander: ");
                    string name = Console.ReadLine();
                    Charmander charmander = new Charmander(name, 10, 5);

                    Console.WriteLine("=== Charmander Battle Cry ===");
                    for (int i = 0; i < 10; i++)
                    {
                        charmander.BattleCry();
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    quitGame = true;
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
