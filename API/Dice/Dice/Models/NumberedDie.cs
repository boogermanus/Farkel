
namespace Dice.Models;

public class NumberedDie : BaseDie<int>
{
    public NumberedDie(IEnumerable<int> sides) : base(sides)
    {

    }

    public NumberedDie(int sides) : base(Enumerable.Range(1, sides))
    {

    }

    public override void Roll()
    {
        var random = new Random();
        var roll = random.Next(1, SidesCount - 1);
        _currentRoll = roll;
    }
}