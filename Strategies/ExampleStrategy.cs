public class ExampleStrategy : IStrategy
{
    public string Author => "Default";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Cooperate;
    }

    public TurnAction TakeTurn(TurnLog turnLog)
    {
        return TurnAction.Cooperate;
    }
}