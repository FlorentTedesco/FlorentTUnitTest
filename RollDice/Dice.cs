using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RollDice
{
    class Dice
    {
        public List<int> ResultDiceInputs(string dice)
        {
            List<string> listRolls = GetCorrectRolls(dice);
            List<int> validatedRolls = new List<int>();
            int index = 4; 

            foreach (var roll in listRolls)
            {
                string[] rollElements = Regex.Split(roll, @"(d)");

                if (int.TryParse(rollElements[0], out int valueX))
                {
                    
                }
            }

            return validatedRolls;
        }

        //public bool VerifyArguments(int dice)
        //{
        //    return true;
        //}

        public int VerifyDice(int dice)
        {
            if ((dice < 1) || (dice > 100))
            {
                return dice;
            }
        }

        public bool VerifyFaces(int face)
        {
            if ((face < 2) || (face > 100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool VerifyModifier(int modifier)
        {
            if ((modifier < 0) || (modifier > 100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //GetSum

        public List<string> GetCorrectRolls(string input)
        {
            List<string> correctRolls = new List<string>();

            string[] rolls = input.Split(' ');

            foreach (var roll in rolls)
            {
                if (Regex.IsMatch(input, @"(\d *)(d)(\d *)([\(]([+-]\d *)[\)])"))
                {
                    correctRolls.Add(roll);
                }
                else
                {
                    //error
                }
            }

            return correctRolls;
        }
    }
}
