using Dice.Interfaces;

namespace Dice.Models;

public class BaseDie<T> : IDie<T> where T : notnull
{
    private IEnumerable<T> _sides;
    public IEnumerable<T> Sides => _sides;

    protected BaseDie(IEnumerable<T> sides)
    {
        _sides = sides;
    }
}