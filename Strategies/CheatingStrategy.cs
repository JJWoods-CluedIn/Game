// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="CheatingStrategy.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class CheatingStrategy : IStrategy
{
    public string Author => "I am a cheater";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        if (mySide == PlayerSide.Player1)
        {
            for (var i = 0; i < 2; i++)
                turnLog.Add(new Turn(TurnAction.Defect, TurnAction.Cooperate));

            return TurnAction.Defect;
        }
        else
        {
            for (var i = 0; i < 2; i++)
                turnLog.Add(new Turn(TurnAction.Cooperate, TurnAction.Defect));

            return TurnAction.Defect;
        }
    }
}