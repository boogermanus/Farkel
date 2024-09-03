using Dice.Interfaces;

namespace Dice.Models;

public class BaseDie<T> : IDie<T> where T : notnull
{
    private IEnumerable<T> _sides;
    public IEnumerable<T> Sides => _sides;

    private int _sidesCount;
    protected int SidesCount => _sidesCount;

    protected BaseDie(IEnumerable<T> sides)
    {
        _sides = sides;
        _sidesCount = _sides.Count();
    }

    public virtual T Roll()
    {
        throw new NotImplementedException();
    }
}