namespace Dice.Library.Interfaces;

public interface IDie<T> where T : notnull
{
    public void Roll();
    public T CurrentRoll { get; }
}