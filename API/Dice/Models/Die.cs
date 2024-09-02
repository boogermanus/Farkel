using Dice.Interfaces;

namespace Dice.Models;

public class Die : IDie
{
    public Die(int sides = 6)
    {
        numberOfSides = sides;
    }

    private int numberOfSides;
    public int NumberOfSides { get => numberOfSides; }
    private int currentRoll;
    public int CurrentRoll
    {
        get { return currentRoll; }
        set { currentRoll = value; }
    }

    public void Roll()
    {
        var random = new Random();
        var roll = random.Next(1, NumberOfSides -1);
        currentRoll = roll;
    }
}
