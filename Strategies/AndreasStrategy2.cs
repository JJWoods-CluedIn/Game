using Game.Game;

namespace Game.Strategies
{
    internal class AndreasStrategy2 : IStrategy
    {
        public string Author => "Andreas - 2";

        public TurnAction TakeFirstTurn()
        {
            return TurnAction.Defect;
        }

        public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
        {
            var myScore = turnLog.GetPlayerScore(mySide);
            var otherScore = turnLog.GetPlayerScore(mySide == PlayerSide.Player1 ? PlayerSide.Player1 : PlayerSide.Player2);

            if (myScore <= otherScore)
            {
                return TurnAction.Defect;
            }

            return TurnAction.Cooperate;
        }
    }
}
