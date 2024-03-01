// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ChaosStrategy.cs" company="Clued In">
// //   Copyright (c) 2024 Clued In. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Game.Game;

public class ChaosStrategy : IStrategy
{
    private static Random rnd = new();

    public string Author => "Chaos";

    public TurnAction TakeFirstTurn()
    {
        return GetRandomResponse();
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        return GetRandomResponse();
    }

    private static TurnAction GetRandomResponse()
    {
        if (rnd.NextSingle() > 0.5)
            return TurnAction.Cooperate;
        else
            return TurnAction.Defect;
    }
}