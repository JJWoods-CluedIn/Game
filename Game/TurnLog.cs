public class TurnLog
{
    public List<Turn> Log { get; }

    public TurnLog()
    {
        Log = new List<Turn>();
    }

    public void Add(Turn turn)
        => Log.Add(turn);


    public int GetPlayer1Score()
        => Log.Sum(turn => turn.GetPlayer1Score());
}