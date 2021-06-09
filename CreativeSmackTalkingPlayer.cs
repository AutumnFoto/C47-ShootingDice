using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        // list of Taunts
        public List<string> TauntList = new List<string>();

        public override int Roll()
        {
            // setting a random taunt to appear next to persons name, and a random dice size plus one
            Random random = new Random();
            int randomTaunt = random.Next(TauntList.Count);
            Console.WriteLine($"{this.Name} - {TauntList[randomTaunt]}");
            return new Random().Next(DiceSize) + 1;
        }

    }
}