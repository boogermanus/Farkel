namespace Dice.Interfaces;

public interface IDie<T> where T : notnull
{
    public void Roll();

}