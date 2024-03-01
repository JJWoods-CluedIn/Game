﻿using Game.Game;

namespace Game.Strategies
{
    internal class AndreasStrategy : IStrategy
    {
        public string Author => "Andreas";

        public TurnAction TakeFirstTurn()
        {
            return TurnAction.Defect;
        }

        public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
        {
            var myScore = turnLog.GetPlayerScore(mySide);
            var otherScore = turnLog.GetPlayerScore(mySide == PlayerSide.Player1 ? PlayerSide.Player1 : PlayerSide.Player2);

            if (myScore >= otherScore)
            {
                return TurnAction.Defect;
            }

            return TurnAction.Cooperate;
        }
    }

    public static class TurnlogExtenstions
    {
        public static int GetPlayerScore(this TurnLog turnLog, PlayerSide side)
        {
            return turnLog.Log.Select(x =>
            {
                switch (x.TurnOuctcome)
                {
                    case TurnOuctcome.BothCooperate:
                        return 3;
                        break;
                    case TurnOuctcome.BothDefect:
                        return 1;
                        break;
                    case TurnOuctcome.Player1Defects:
                        return side == PlayerSide.Player1 ? 5 : 0;
                        break;
                    case TurnOuctcome.Player2Defects:
                        return side == PlayerSide.Player2 ? 5 : 0;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }).Sum();
        }
    }
}
