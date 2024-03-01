using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Game;

namespace Game.Strategies
{
    internal class AndreasStrategy3 : IStrategy
    {
        private static Random random = new();

        public string Author => "Andreas - 3";

        public TurnAction TakeFirstTurn()
        {
            if (random.NextSingle() > 0.5)
            {
                return TurnAction.Cooperate;
            }
            
            return TurnAction.Defect;
        }

        public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
        {
            var otherPlayDefects = 0;

            var otherPlayerDefectActions = turnLog.Log.Select(x =>
            {
                if (mySide == PlayerSide.Player1)
                {
                    return x.Player2Action;
                }

                return x.Player1Action;
            }).Where(x => x == TurnAction.Defect);

            if (otherPlayerDefectActions.Count() > turnLog.Log.Count / 2)
            {
                return TurnAction.Defect;
            }

            return TurnAction.Cooperate;
        }
    }
}
