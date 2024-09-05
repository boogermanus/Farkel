using Farkel.Core.Enums;
using Farkel.Core.Models;

namespace Farkel.Testing;

[TestFixture]
public class GameTests
{
    private Game _game;
    [SetUp]
    public void Setup()
    {
        _game = new Game("test");
    }

    [TearDown]
    public void TearDown()
    {
        _game = null;
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
}