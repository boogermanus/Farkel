using Farkel.Core.Interfaces;

namespace Farkel.Core.Models;

public class Player : IPlayer
{
    private string _id;
    public string Id => _id;

    private string _name;
    public string Name => _name;

    private int _points = 0;
    public int Points => _points;

    public Player(string id, string name)
    {
        _id = id;
        _name = name;
    }

    public void ScorePoints(int points)
    {
        _points += points;
    }
}