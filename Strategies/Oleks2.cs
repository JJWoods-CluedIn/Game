using Game.Game;
using Game.Strategies;

public class Oleks2 : IStrategy
{
    public string Author => "Oleks2";
    
    public TurnAction TakeFirstTurn()
    {
        return OleksUtil.GetRandomAction();
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        return OleksUtil.GetRandomAction();
    }

}