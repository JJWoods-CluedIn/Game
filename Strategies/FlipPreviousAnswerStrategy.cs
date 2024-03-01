// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlipPreviousAnswerStrategy.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class FlipPreviousAnswerStrategy : IStrategy
{
    public string Author => "Flip Previous Answer";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var last = turnLog.Log.Last();

        return mySide == PlayerSide.Player1
                   ? (last.Player2Action == TurnAction.Cooperate ? TurnAction.Defect : TurnAction.Cooperate)
                   : (last.Player1Action == TurnAction.Cooperate ? TurnAction.Defect : TurnAction.Cooperate);
    }
}