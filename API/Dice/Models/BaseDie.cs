using Dice.Interfaces;

namespace Dice.Models;

public abstract class BaseDie<T> : IDie<T> where T : notnull
{
    protected BaseDie()
    {
    }

    public void Roll()
    {
        throw new NotImplementedException();
    }
}