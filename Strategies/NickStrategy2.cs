using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Game;

namespace Game.Strategies;
internal class NickStrategy2 : IStrategy
{
    public string Author { get; } = "I am getting more paranoid...";
    public int ParanoidMeter { get; set; } = 0;
    public int ParanoidIncreaseMax { get; set; } = 1;
    public Random Random { get; set; } = new Random();
    public TurnAction TakeFirstTurn()
    {
        return MakeDecision();
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        return MakeDecision();
    }

    private TurnAction MakeDecision()
    {
        var number = Random.Next(0,100);
        var a = number * ParanoidMeter;

        ParanoidMeter += Random.Next(0, 5);

        return a > 10000 ? TurnAction.Defect : TurnAction.Cooperate;
    }
}
