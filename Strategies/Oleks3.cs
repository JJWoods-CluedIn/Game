using Game.Game;

// This is tit for tat
public class Oleks3 : IStrategy
{
    public string Author => "Oleks3";
    
    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Cooperate;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var otherAction = turnLog.Log.Last().GetOtherPlayerAction(mySide);

        if (otherAction == TurnAction.Defect)
        {
            return TurnAction.Defect;
        }
        else
        {
            return TurnAction.Cooperate;
        }
    }
}