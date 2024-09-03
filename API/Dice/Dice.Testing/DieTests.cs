using Dice.Models;

namespace Dice.Testing;

[TestFixture]
public class DieTests
{
    private NumberedDie _numberedDie;
    [SetUp]
    public void Setup()
    {
        _numberedDie = new NumberedDie([1,2,3,4,5,6]);
    }

    [Test]
    public void RollIsGreaterThanZero()
    {
        var count = Enumerable.Range(0,100);
        foreach(var roll in count)
        {
            Assert.That(() => _numberedDie.Roll(), Is.GreaterThan(0));
        }
    }

    [Test]
    public void RollIsLessThanOrEqualToSix()
    {
        var count = Enumerable.Range(0,100);

        foreach(var roll in count)
        {
            Assert.That(() => _numberedDie.Roll(), Is.LessThanOrEqualTo(6));
        }
    }
}