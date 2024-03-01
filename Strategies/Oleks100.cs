using Game.Game;
using Game.Strategies;

// This is just to exploit the flow of playing against your own strategies
// You negotiate it's a known strategy
// After that lots are feeding into one who eats.

public abstract class Oleks100Base : IStrategy
{
    public string Author => GetType().Name;
    
    public TurnAction TakeFirstTurn()
    {
        return OleksUtil.AuthSequence[0];
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        // First communicate your sequenced
        if (turnLog.Log.Count < OleksUtil.AuthSequence.Length)
        {
            return OleksUtil.AuthSequence[turnLog.Log.Count];
        }

        var otherPlayerAuthMoves = turnLog.Log.Select(x => x.GetOtherPlayerAction(mySide));

        if (OleksUtil.AuthSequence.SequenceEqual(otherPlayerAuthMoves.Take(OleksUtil.AuthSequence.Length)))
        {
            return GetAuthorizedMove();
        }

        return GetNonAuthorizedMove();
    }

    protected abstract TurnAction GetAuthorizedMove();
    
    protected abstract TurnAction GetNonAuthorizedMove();
}

// Should win
public class Oleks100 : Oleks100Base
{
    protected override TurnAction GetAuthorizedMove() => TurnAction.Defect;

    protected override TurnAction GetNonAuthorizedMove() => TurnAction.Defect;
}

public class Oleks100FeedBase : Oleks100Base
{
    protected override TurnAction GetAuthorizedMove() => TurnAction.Cooperate;

    protected override TurnAction GetNonAuthorizedMove() => TurnAction.Defect;
}

public class Oleks101 : Oleks100FeedBase { };
public class Oleks102 : Oleks100FeedBase { };
public class Oleks103 : Oleks100FeedBase { };
public class Oleks104 : Oleks100FeedBase { };
public class Oleks105 : Oleks100FeedBase { };
public class Oleks106 : Oleks100FeedBase { };
public class Oleks107 : Oleks100FeedBase { };
public class Oleks108 : Oleks100FeedBase { };
public class Oleks109 : Oleks100FeedBase { };
public class Oleks110 : Oleks100FeedBase { };
public class Oleks111 : Oleks100FeedBase { };
public class Oleks112 : Oleks100FeedBase { };
public class Oleks113 : Oleks100FeedBase { };
public class Oleks114 : Oleks100FeedBase { };
public class Oleks115 : Oleks100FeedBase { };
public class Oleks116 : Oleks100FeedBase { };
public class Oleks117 : Oleks100FeedBase { };
public class Oleks118 : Oleks100FeedBase { };
public class Oleks119 : Oleks100FeedBase { };
public class Oleks120 : Oleks100FeedBase { };
public class Oleks121 : Oleks100FeedBase { };
public class Oleks122 : Oleks100FeedBase { };
public class Oleks123 : Oleks100FeedBase { };
public class Oleks124 : Oleks100FeedBase { };
public class Oleks125 : Oleks100FeedBase { };
public class Oleks126 : Oleks100FeedBase { };
public class Oleks127 : Oleks100FeedBase { };
public class Oleks128 : Oleks100FeedBase { };
public class Oleks129 : Oleks100FeedBase { };
public class Oleks130 : Oleks100FeedBase { };
