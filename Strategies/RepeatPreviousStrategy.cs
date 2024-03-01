// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="RepeatPreviousStrategy.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class RepeatOtherPlayerPreviousAnswerStrategy : IStrategy
{
    private static Random rnd = new();

    public string Author => "Repeat Other Player Previous Answer";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var last = turnLog.Log.Last();

        return mySide == PlayerSide.Player1 ? last.Player2Action : last.Player1Action;
    }
}