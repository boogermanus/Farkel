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

    public Game(string id)
    {
        _id = id;
    }

    public void AddPlayer(IPlayer player)
    {
        throw new NotImplementedException();
    }
}