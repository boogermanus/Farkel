namespace Farkel.Core.Interfaces;

public interface IGame
{
    string Id { get; }
    int NumberOfPlayers { get; }
    IEnumerable<IPlayer> Players { get; }
    void AddPlayer(IPlayer player);
}