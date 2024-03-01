using Game.Game;

public class GameFactory : IGameFactory
{
    readonly int TurnCount;

    public GameFactory(int turnCount)
    {
        TurnCount = turnCount;
    }

    public TurnLog RunGame(IStrategy player1, IStrategy player2)
    {
        var turnLog = new TurnLog();

        for(int count1 = 0; count1 < TurnCount; count1++)
        {
            var turn = TakeTurn(player1, player2, turnLog);
            turnLog.Add(turn);
        }

        return turnLog;
    }

    private Turn TakeTurn(IStrategy player1, IStrategy player2, TurnLog log)
    {
        TurnAction player1Action;
        TurnAction player2Action;

        if(log.Log.Count == 0)
        {
            player1Action = player1.TakeFirstTurn();
            player2Action = player2.TakeFirstTurn();
        }
        else
        {
            player1Action = player1.TakeTurn(log, PlayerSide.Player1);
            player2Action = player2.TakeTurn(log, PlayerSide.Player2);
        }

        var turn = new Turn(player1Action, player2Action);
        return turn;
    }
}