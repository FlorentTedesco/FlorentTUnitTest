using NUnit.Framework;
using Dice.Services;

namespace Dice.UnitTests.Services
{
    [TestFixture]
    public class DiceService_Tests
    {
        private readonly DiceService _diceService;

        public DiceService_Tests()
        {
            _diceService = new DiceService();
        }

        [TestCase("s")]
        [TestCase(5)]
        public void AreInputsInts(int value)
        {
            var result = _diceService.VerifyInputs(value);

            Assert.IsFalse(result, $"{value} n'est pas un int");
        }

        [TestCase(0)]
        [TestCase(50)]
        [TestCase(101)]
        public void IsDiceNumberCorrect()
        {
            var result = _diceService.VerifyDice(value);

            Assert.IsFalse(result, $"{value} n'est pas un nombre de dés correct, il doit être compris entre 1 et 100");
        }

        [TestCase(1)]
        [TestCase(50)]
        [TestCase(101)]
        public void IsFaceNumberCorrect()
        {
            var result = _diceService.VerifyFaces(value);

            Assert.IsFalse(result, $"{value} n'est pas un nombre de faces correct, il doit être compris entre 2 et 100");
        }

        [TestCase(0)]
        [TestCase(50)]
        [TestCase(101)]
        public void IsModifierNumberCorrect()
        {
            var result = _diceService.VerifyModifier(value);

            Assert.IsFalse(result, $"{value} n'est pas un nombre correct pour le modificateur");
        }

        [TestCase("6p3")]
        [TestCase("54d20(-50)")]
        [TestCase("60d50+50")]
        public void IsThrowSyntaxCorrect()
        {
            var result = _diceService.ThrowErrorUnhandledSyntax(value);

            Assert.IsFalse(result, $"{value} n'est pas la syntaxe correcte pour un lancer de dés");
        }
    }
}