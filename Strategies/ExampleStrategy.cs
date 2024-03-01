using Game.Game;

public class ExampleStrategy : IStrategy
{
    public string Author => "Default";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Cooperate;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        return TurnAction.Cooperate;
    }
}