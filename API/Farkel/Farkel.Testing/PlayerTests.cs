using Farkel.Core.Models;

namespace Farkel.Testing;

[TestFixture]
public class PlayerTests
{
    [Test]
    public void PlayerShouldThrowIfIdNull()
    {
        Assert.That(() => new Player(null, null), Throws.ArgumentNullException);
    }

    [Test]
    public void PlayerShouldThrowIfIdIsEmpty()
    {
        Assert.That(() => new Player(string.Empty, null), Throws.ArgumentNullException);
    }

    [Test]
    public void PlayerShouldThrowINameNull()
    {
        Assert.That(() => new Player("null", null), Throws.ArgumentNullException);
    }

    [Test]
    public void PlayerShouldThrowIfNameIsEmpty()
    {
        Assert.That(() => new Player("Empty", string.Empty), Throws.ArgumentNullException);
    }
}