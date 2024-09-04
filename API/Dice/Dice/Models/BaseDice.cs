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

        // if dice count less than 1;
        if(_diceCount == 0)
            throw new ArgumentException($"{nameof(dice)} cannot be less than one");

        int id = 1;
        foreach(var die in Dice)
        {
            die.SetId(id++);
        }
    }

    public void Roll()
    {
        Dice.ToList().ForEach(die => die.Roll());
    }
}