// See https://aka.ms/new-console-template for more information
namespace PokemonBattleSimulator
{

    class Program
    {

        static void Main(string[] args)
        {
            bool continuePlaying = true;
            Console.Write("Do you want to play the Pokemon Battle Simulator? [Y/N]:");
            String yesNoVarInitial = Console.ReadLine();
            if (yesNoVarInitial == "Y")
            {
                while (continuePlaying == true)
                {
                    String name = giveName();
                    Charmander charmander = new Charmander(name, "fire", "weakness");
                    charmander.battleCry(10);

                    Console.Write(Environment.NewLine + "Do you want to play again? [Y/N]:");
                    String yesNoVarAgain = Console.ReadLine();
                    
                    if(yesNoVarAgain == "N")
                    {
                        continuePlaying = false;
                        Console.WriteLine("Have a nice day!");

                    }

                }
            }

        }

        public static String giveName()
        {
            Console.Write(Environment.NewLine + "Give your Charmander a name: ");
            String name = Console.ReadLine();
            // call the setName function from charmander and pass the name variable 
            Console.WriteLine(Environment.NewLine + "Your Charmander's name is " + name + Environment.NewLine);
            return name;
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

        public void battleCry(int amountBattleCry)
        {
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(this.name + " does battlecry " + i + '!');
            }
        }

        //maak een setNAme functie die een name parameter ontvangt, en de waarde van het field "name" aanpast
        //....


    }

}