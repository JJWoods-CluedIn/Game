public class Turn
{
    public TurnAction Player1Action { get; }

    public TurnAction Player2Action { get; }

    public TurnOuctcome TurnOuctcome { get; }

    public Turn(TurnAction player1Action, TurnAction player2Action)
    {
        Player1Action = player1Action;
        Player2Action = player2Action;
        TurnOuctcome = CalculateOutcome(player1Action, player2Action);
    }

    private TurnOuctcome CalculateOutcome(TurnAction player1Action, TurnAction player2Action)
    {
        if(player1Action.Equals(TurnAction.Cooperate) && player2Action.Equals(TurnAction.Cooperate))
            return TurnOuctcome.BothCooperate;

        if(player1Action.Equals(TurnAction.Cooperate) && player2Action.Equals(TurnAction.Defect))
            return TurnOuctcome.Player2Defects;

        if(player1Action.Equals(TurnAction.Defect) && player2Action.Equals(TurnAction.Cooperate))
            return TurnOuctcome.Player1Defects;

        if(player1Action.Equals(TurnAction.Defect) && player2Action.Equals(TurnAction.Defect))
            return TurnOuctcome.BothDefect;

        return TurnOuctcome.Unknown;
    }

    public int GetPlayer1Score()
    {
        switch(TurnOuctcome)
        {
            case TurnOuctcome.BothCooperate:
                return 3;

            case TurnOuctcome.BothDefect:
                return 1;

            case TurnOuctcome.Player1Defects:
                return 5;

            case TurnOuctcome.Player2Defects:
                return 0;

            default:
                throw new ArgumentOutOfRangeException("Unknown turn outcome. Cannot score");
        }
    }
}