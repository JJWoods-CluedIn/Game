using Game.Game;

public class Oleks1 : IStrategy
{
    public string Author => "Oleks1";
    
    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var otherAction = turnLog.Log.Last().GetOtherPlayerAction(mySide);

        if (otherAction == TurnAction.Defect)
        {
            return TurnAction.Cooperate;
        }
        else
        {
            return TurnAction.Defect;
        }
    }
}