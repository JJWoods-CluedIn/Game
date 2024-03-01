using System.Security.Cryptography;

namespace Game.Strategies;

public static class OleksUtil
{
    public static TurnAction[] AuthSequence { get; }

    static OleksUtil()
    {
        // 10 should be enough for uniqueness
        AuthSequence = Enumerable.Repeat(0, 10).Select(_ => GetRandomAction()).ToArray();
    }
    
    public static TurnAction GetRandomAction()
    {
        return RandomNumberGenerator.GetInt32(0, 2) == 0 ? TurnAction.Cooperate : TurnAction.Defect;
    }
    
}