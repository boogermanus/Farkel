using Dice.Interfaces;

namespace Dice.Models;

public class Dice<T> : BaseDice<T> where T : notnull
{
    public Dice(IEnumerable<IDie<T>> dice) : base(dice)
    {
    }
}