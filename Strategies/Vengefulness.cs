using Game.Game;

namespace Game.Strategies
{
    internal class Vengefulness : IStrategy
    {
        public string Author => "Vengeful";

        public TurnAction TakeFirstTurn()
        {
            return TurnAction.Cooperate;
        }

        public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
        {
            var wasEverBetrayed = turnLog.Log.Any(x =>
            {
                if (mySide == PlayerSide.Player1)
                {
                    return x.Player2Action == TurnAction.Defect;
                }

                return x.Player1Action == TurnAction.Defect;
            });

            if (wasEverBetrayed)
            {
                return TurnAction.Defect;
            }

            return TurnAction.Cooperate;
        }
    }
}
