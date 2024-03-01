public interface IStrategy
{
    string Author { get; }

    TurnAction TakeFirstTurn();

    TurnAction TakeTurn(TurnLog turnLog);
}