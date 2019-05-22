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
        public void AreEntriesInts(int value)
        {
            var result = _diceService.VerifyEntries(value);

            Assert.IsFalse(result, $"{value} n'est pas un int");
        }

        [Test]
        public void InitDice()
        {
            var result = _diceService.VerifyArguments(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        [Test]
        public void InitDice()
        {
            var result = _diceService.InitDice(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}