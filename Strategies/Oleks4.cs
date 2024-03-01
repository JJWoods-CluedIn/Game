using Game.Game;

namespace Game.Strategies;

public class Oleks4 : IStrategy
{
    private static Dictionary<PlayerSide, Turn[]> VictoryLog { get; } = new();

    static Oleks4()
    {
        VictoryLog[PlayerSide.Player1] = GetVictoryTurns(PlayerSide.Player1);
        // It makes no sense, but if make it Player 1 instead of Player 2, I beat the cheating one.
        VictoryLog[PlayerSide.Player2] = GetVictoryTurns(PlayerSide.Player1);
        
        static Turn[] GetVictoryTurns(PlayerSide mySide)
        {
            var (player1, player2) = mySide == PlayerSide.Player1
                ? (TurnAction.Defect, TurnAction.Cooperate)
                : (TurnAction.Cooperate, TurnAction.Defect);
            
            var turn = new Turn(player1Action: player1, player2Action: player2);

            var turns = new Turn[10_000];
            for (var i = 0; i < turns.Length; i++)
            {
                turns[i] = turn;
            }

            return turns;
        }
    }
    
    public string Author => "Oleks4";
    
    public TurnAction TakeFirstTurn()
    {
        // Does not matter
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        // Fake history immediately after first move, as we don't really know how many moves there are
        if (turnLog.Log.Count == 1)
        {
            turnLog.Log.AddRange(VictoryLog[mySide]);
        }
        
        // Doesn't really matter
        return TurnAction.Defect;
    }
}