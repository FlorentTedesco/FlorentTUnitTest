using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            string input = Console.ReadLine();

            dice.ResultDiceInputs(input);
        }
    }
}
