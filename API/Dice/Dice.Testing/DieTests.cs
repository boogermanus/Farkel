using Dice.Models;

namespace Dice.Testing;

[TestFixture]
public class DieTests
{
    private NumberedDie _numberedDie;
    private readonly IEnumerable<int> _count = Enumerable.Range(0, 100);

    [SetUp]
    public void Setup()
    {
        _numberedDie = new NumberedDie([1, 2, 3, 4, 5, 6]);
    }

    [Test]
    public void RollIsGreaterThanZero()
    {
        foreach (var roll in _count)
        {
            _numberedDie.Roll();
            Assert.That(() => _numberedDie.CurrentRoll, Is.GreaterThan(0));
        }
    }

    [Test]
    public void RollIsLessThanOrEqualToSix()
    {
        foreach (var roll in _count)
        {
            _numberedDie.Roll();
            Assert.That(() => _numberedDie.CurrentRoll, Is.LessThanOrEqualTo(6));
        }
    }

    [Test]
    public void ThrowsIfZeroOrLess()
    {
        Assert.That(() => new NumberedDie(new List<int>()), Throws.ArgumentException);
    }

    [Test]
    public void ThrowsIfZeroOrLessWithMessage()
    {
        Assert.That(() => new NumberedDie(new List<int>()), Throws.ArgumentException.With.Message.Contain("zero"));
    }

    [Test]
    public void ThrowsIfSidesGreaterThanTwenty()
    {
        Assert.That(() => new NumberedDie(new List<int>(Enumerable.Range(1,21))), Throws.ArgumentException);
    }

    [Test]
    public void ThrowsIfSidesGraterThanTwnetyWithMessage()
    {
        Assert.That(() => new NumberedDie(new List<int>(Enumerable.Range(1,21))), Throws.ArgumentException.With.Message.Contain("twenty"));
    }
}