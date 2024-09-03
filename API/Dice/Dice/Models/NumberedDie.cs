
namespace Dice.Models;

public class NumberedDie : BaseDie<int>
{
    public NumberedDie(IEnumerable<int> sides) : base(sides)
    {

    }

    public override int Roll()
    {
        var random = new Random();
        var roll = random.Next(1, SidesCount - 1);
        return roll;
    }
}