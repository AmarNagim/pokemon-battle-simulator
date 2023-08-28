// See https://aka.ms/new-console-template for more information
// ASSIGNMENT 2


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

                    if (yesNoVarAgain == "N")
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


    

    //class Pokeball()
    //    {

    //    }




}