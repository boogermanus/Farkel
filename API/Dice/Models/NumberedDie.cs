
namespace Dice.Models;

public class NumberedDie : BaseDie<int>
{
    public NumberedDie(IEnumerable<int> values) : base(values)
    {
    }
}