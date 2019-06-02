using System;
using System.Text.RegularExpressions;

namespace DiceService
{
    public class DiceService
    {
        public bool VerifyInputs(int dice, int face)
        {
            if ((int.TryParse(dice, out value)) && (int.TryParse(face, out value)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyDice(int dice)
        {
            if ((dice < 1) || (dice > 100))
            {
                return false;
            }
            else
            {
                return true;
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

        public bool ThrowErrorUnhandledSyntax()
        {
            Regex rx = new Regex(@"(\d *)(d)(\d *)([\(]([+-]\d *)[\)])");
            if (rx.Match())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
