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

    public event EventHandler? GameStarted;

    public IEnumerable<IPlayer> Players => _players;

    public GameState GameState { get; set; }
    public event EventHandler? PlayerTurn;

    private IPlayer? _currentPlayer;
    public IPlayer? CurrentPlayer => _currentPlayer;

    private int _playerIndex = 0;
    private IPlayer? _nextPlayer;
    public IPlayer? NextPlayer => _nextPlayer;

    public Game(string id)
    {
        _id = id;
        GameState = GameState.WaitingForPlayers;
    }

    public void AddPlayer(IPlayer player)
    {
        _players.Add(player);
        _numberOfPlayers++;

        if(_numberOfPlayers > 1 )
            GameState = GameState.ReadyToPlay;
    }

    public void StartGame()
    {
        if(GameState != GameState.ReadyToPlay)
            throw new InvalidOperationException("Game must have at last two players");

        GameState = GameState.Playing;

        GameStarted?.Invoke(this, EventArgs.Empty);
        SetPlayers();
    }

    private void SetPlayers()
    {
        _currentPlayer = _players[_playerIndex];
        _nextPlayer = _players[_playerIndex + 1];
        _playerIndex++;
        if(_playerIndex == _numberOfPlayers)
            _playerIndex = 0;
    }
}