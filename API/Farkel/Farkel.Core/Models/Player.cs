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
        if(string.IsNullOrEmpty(id))
            throw new ArgumentNullException(nameof(id));

        _id = id;

        if(string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));

        _name = name;
    }

    public void ScorePoints(int points)
    {
        if(points < 0)
            throw new InvalidOperationException("Points cannot be less than zero");
        
        _points += points;
    }
}