using Farkel.Core.Enums;

namespace Farkel.Core.Interfaces;

public interface IGame
{
    string Id { get; }
    int NumberOfPlayers { get; }
    IEnumerable<IPlayer> Players { get; }
    GameState GameState { get; set; }
    void AddPlayer(IPlayer player);
}