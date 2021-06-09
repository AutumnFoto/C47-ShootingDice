using System;
namespace ShootingDice

{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            // Human Player can enter rolled number.
            Console.Write("Enter your roll: ");
            int EnteredRoll = int.Parse(Console.ReadLine());
            return EnteredRoll;
        }

    }
}