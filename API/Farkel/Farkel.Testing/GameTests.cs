using Farkel.Core.Enums;
using Farkel.Core.Interfaces;
using Farkel.Core.Models;

namespace Farkel.Testing;

[TestFixture]
public class GameTests
{
    private IGame _game;
    [SetUp]
    public void Setup()
    {
        _game = new Game("test");
    }
    
    [Test]
    public void GameShouldSetId()
    {
        var id = "game";

        Assert.That(() => new Game(id).Id, Is.EqualTo(id));
    }

    [Test]
    public void GameShouldBeWaitingForPlayers()
    {
        Assert.That(() => _game.GameState, Is.EqualTo(GameState.WaitingForPlayers));
    }

    [Test]
    public void AddPlayerShouldAddPlayer()
    {
        _game.AddPlayer(new Player("1","Bob"));

        Assert.That(_game.Players.Count(), Is.EqualTo(1));
    }

    [Test]
    public void AddPlayersShouldSetGameStateToReadyToPlay()
    {
        _game.AddPlayer(new Player("1","Bob"));
        _game.AddPlayer(new Player("2","Jane"));

        Assert.That(_game.GameState, Is.EqualTo(GameState.ReadyToPlay));
    }

    [Test]
    public void StartGameShouldThrowIfOnlyOnePlayer()
    {
        Assert.That(() => _game.StartGame(), Throws.InvalidOperationException);
    }

    [Test]
    public void StartGameShouldSetGameStateToPlaying()
    {
        _game.AddPlayer(new Player("1","Bob"));
        _game.AddPlayer(new Player("2","Jane"));
        _game.StartGame();
        Assert.That(() => _game.GameState, Is.EqualTo(GameState.Playing));
    }

    [Test]
    public void GameStartedShouldEmit()
    {
        var wasCalled = false;

        _game.GameStarted += (o,e) => wasCalled = true;
        
        _game.AddPlayer(new Player("1","Bob"));
        _game.AddPlayer(new Player("2","Jane"));
        _game.StartGame();

        Assert.That(wasCalled, Is.True);
    }
}