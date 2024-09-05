namespace Farkel.Core.Interfaces;

public interface IPlayer
{
    public string Id { get;}
    public string Name { get;}
    public int Points { get;}
    void ScorePoints(int points);
}