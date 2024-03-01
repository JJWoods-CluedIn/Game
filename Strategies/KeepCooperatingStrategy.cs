// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="OtherOne.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class KeepCooperatingStrategy : IStrategy
{
    public string Author => "Keep Cooperating";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var outcome = turnLog.Log.GroupBy(l => l.TurnOuctcome).OrderByDescending(g => g.Count()).First();

        switch (outcome.Key)
        {
            case TurnOuctcome.BothCooperate:
                return TurnAction.Cooperate;

            case TurnOuctcome.BothDefect:
                return TurnAction.Defect;

            case TurnOuctcome.Player1Defects:
                return TurnAction.Defect;

            case TurnOuctcome.Player2Defects:
                return TurnAction.Defect;

            default:
                throw new Exception();
        }
    }
}