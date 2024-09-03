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
        var dice = new Dice<int>(new List<IDie<int>>());
        Assert.That(() => new Dice<int>(new List<IDie<int>>()), Throws.ArgumentException);
    }
e
    [Test]
    public void ThrowsIfDiceCountIsEualToZeroWithMessage()
    {
        Assert.That(() => new Dice<int>(new List<IDie<int>>()),
            Throws.ArgumentNullException.With.Message.Contain("one"));
    }
}