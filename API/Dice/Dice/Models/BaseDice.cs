using Dice.Interfaces;

namespace Dice.Models;

public class BaseDice<T> : IDice<T> where T : notnull
{
    private IEnumerable<IDie<T>> _dice;

    public IEnumerable<IDie<T>> Dice => _dice;

    private int _diceCount = 0;
    public int DiceCount => _diceCount;

    public BaseDice(IEnumerable<IDie<T>> dice)
    {
        _dice = dice;
        _diceCount = dice.Count();
    }

    public void Roll()
    {
        foreach(var die in Dice)
        {
            die.Roll();
        }
    }
}