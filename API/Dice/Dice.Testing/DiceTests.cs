using Dice.Interfaces;
using Dice.Models;

namespace Dice.Testing;

[TestFixture]
public class DiceTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [TearDown]
    public void TearDown()
    {

    }

    [Test]
    public void ThrowsIfDiceCountEqualToZero()
    {
        Assert.That(() => new Dice<int>(new List<IDie<int>>()), Throws.ArgumentException);
    }

    [Test]
    public void ThrowsIfDiceCountIsEqualToZeroWithMessage()
    {
        Assert.That(() => new Dice<int>(new List<IDie<int>>()),
            Throws.ArgumentException.With.Message.Contain("one"));
    }

    [Test]
    public void ShouldSetIdOfDice()
    {
        var die = new NumberedDie(1);
        var dice = new Dice<int>([die]);

        Assert.That(dice.Dice.First().Id, Is.GreaterThan(0));

    }
}