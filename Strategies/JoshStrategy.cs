using Game.Game;

namespace Game.Strategies
{
    internal class JoshStrategy : IStrategy
    // Let me win please
    {
        public string Author => "Josh - Defection for my protection";

        public TurnAction TakeFirstTurn()
        {
            return TurnAction.Defect;
        }

        public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
        {
          return TurnAction.Defect;
        }
    }
}