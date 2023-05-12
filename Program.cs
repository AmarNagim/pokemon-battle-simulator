// See https://aka.ms/new-console-template for more information
namespace PokemonBattleSimulator {

    class Program {

            static void Main(string[] args){

                Console.WriteLine("Enter name for your Charmander: ");
                string name = Console.ReadLine();

                Charmander Charmander = new Charmander(name, "fire", "weakness");

            }

    }
    
    class Charmander {
        public String name;
        public String strength;
        public String weakness;

        public Charmander(String name, String strength, String weakness)
        {   
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
    }

}