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
            Assert.That(() => _numberedDie.CurrentRoll, Is.LessThanOrEqualTo(6));
        }
    }
}