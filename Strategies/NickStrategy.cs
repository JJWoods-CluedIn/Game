using Game.Game;

namespace Game.Strategies;
internal class NickStrategy : IStrategy
{
    public string MakingYourMindUpLyrics { get; } =
        "You gotta speed it up And then you gotta slow it down 'Cause if you believe that our love can hit the top You gotta play around But soon you will find that there comes a time For making your mind up You gotta turn it on And then you gotta put it out You gotta be sure that it's something Everybody's gonna talk about Before you decide that the time's arrived For making your mind up Don't let your indecision Take you from behind Trust your inner vision Don't let others change your mind And now you really gotta burn it up And make another fly by night Get a run for your money and take a chance And it'll turn out right But when you can see how it's gotta be You're making your mind up And try to look as if you don't care less But if you wanna see some more Bending the rules of the game Will let you find the one you're looking for And then you can show that you think you know You're making your mind up Don't let your indecision Take you from behind Trust your inner vision Don't let others change your mind And now you really gotta speed it up (speed it up) And then you gotta slow it down (slow it down) 'Cause if you believe that our love can hit the top You gotta play around But soon you will find that there comes a time For making your mind up And now you really gotta speed it up (speed it up) And then you gotta slow it down (slow it down) 'Cause if you believe that our love can hit the top You gotta play around But soon you will find that there comes a time For making your mind up For making your mind up For making your mind up For making your mind up";

    public string Author { get; } = "Nick - Making Your Mind Up";

    private readonly Random _rnd = new();

    public TurnAction TakeFirstTurn()
    {
        return TurnAction.Cooperate;
    }

    public TurnAction TakeTurn(TurnLog turnLog, PlayerSide mySide)
    {
        var character = MakingYourMindUpLyrics[_rnd.Next(0, MakingYourMindUpLyrics.Length)];
        bool isInFirstHalf = char.ToUpper(character) >= 'A' && char.ToUpper(character) <= 'M';
        return isInFirstHalf ? TurnAction.Cooperate : TurnAction.Defect;
    }


}
