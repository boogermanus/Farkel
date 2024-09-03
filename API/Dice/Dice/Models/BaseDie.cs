using Dice.Interfaces;

namespace Dice.Models;

public class BaseDie<T> : IDie<T> where T : notnull
{
    private IEnumerable<T> _sides;
    public IEnumerable<T> Sides => _sides;

    private int _sidesCount;
    protected int SidesCount => _sidesCount;

    protected T _currentRoll;
    public T CurrentRoll => _currentRoll;

    protected BaseDie(IEnumerable<T> sides)
    {
        _sides = sides;
        _sidesCount = _sides.Count();

        if (_sidesCount <= 0)
            throw new ArgumentException("Sides cannot be less than zero");

        if(_sidesCount > 20)
            throw new ArgumentException("sides cannot be greater than twenty");
    }

    public virtual void Roll()
    {
        throw new NotImplementedException();
    }
}