namespace Dice.Interfaces;

public interface IDie<T> where T : notnull
{
    int Id { get; }
    IEnumerable<T> Sides { get; }
    T CurrentRoll { get; }
    void Roll();
    void SetId(int id);
}