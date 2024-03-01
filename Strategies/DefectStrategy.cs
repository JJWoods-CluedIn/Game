// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DefectStrategy.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class DefectStrategy : IStrategy
{
    public string Author => "Always Defect";

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Defect;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        return TurnAction.Defect;
    }
}