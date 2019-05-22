using System;

namespace DiceService
{
    public class DiceService
    {
        //Vérifier que les entrées soient des int
        //Vérifier que tous les arguments soient remplis
        //Vérifier que le nombre de dés est compris entre 1 et 100
        //Vérifier que le nombre de faces est compris entre 2 et 100
        //Vérifier que le modificateur par défaut est 0
        //Vérifier que le modificateur est compris entre -100 et +100
        //Vérifier que le dés par défaut est 1d6
        public bool VerifyEntries(string rolls)
        {
            return true;
        }

        public bool VerifyArguments(int dice)
        {
            return true;
        }

        public bool VerifyDice(int dice)
        {
            return true;
        }

        public bool VerifyFaces(int dice)
        {
            return true;
        }

        public bool VerifyModifierByDefault(string dice)
        {
            return true;
        }

        public bool VerifyModifier(string dice)
        {
            return true;
        }

        public bool VerifyDiceByDefault()
        {
            return true;
        }

        public bool ThrowErrorUnhandledSyntax()
        {
            return true;
        }
    }
}
