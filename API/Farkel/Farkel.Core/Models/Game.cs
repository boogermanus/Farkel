using Farkel.Core.Enums;
using Farkel.Core.Interfaces;

namespace Farkel.Core.Models;

public class Game : IGame
{
    private string _id;
    public string Id => _id;

    private int _numberOfPlayers = 0;
    public int NumberOfPlayers => _numberOfPlayers;

    private List<IPlayer> _players = new List<IPlayer>();
    public IEnumerable<IPlayer> Players => _players;

    public GameState GameState { get; set; }

    public Game(string id)
    {
        _id = id;
        GameState = GameState.WaitingForPlayers;
    }

    public void AddPlayer(IPlayer player)
    {
        _players.Add(player);
    }
}