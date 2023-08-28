using System;


namespace PokemonBattleSimulator
{
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

    }
}
