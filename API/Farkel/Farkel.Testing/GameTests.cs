using Farkel.Core.Models;

namespace Farkel.Testing;

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
}