using Dice.Interfaces;

namespace Dice.Models;

public class BaseDise<T> : IDice<T> where T : notnull
{
    public IEnumerable<IDie<T>> Dice => throw new NotImplementedException();
}