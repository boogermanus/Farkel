using Dice.Library.Interfaces;

namespace Dice.Library.Models;

public abstract class BaseDie<T> : IDie<T> where T : notnull
{
    protected BaseDie(IEnumerable<T> sides)
    {
        _sides = sides;
    }

    private IEnumerable<T> _sides;
    public IEnumerable<T> Sides {get => _sides;}
    public T CurrentRoll => throw new NotImplementedException();

    public void Roll()
    {
        throw new NotImplementedException();
    }
}