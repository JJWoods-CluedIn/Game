using Game.Strategies;

Main();

void Main()
{
    var gameFactory = new GameFactory(1000);

    var strategies = new List<IStrategy>
    {
        new ExampleStrategy(),
        new DefectStrategy(),
        new ChaosStrategy(),
        new RepeatOtherPlayerPreviousAnswerStrategy(),
        new AndreasStrategy(),
        new AndreasStrategy2(),
        new FlipPreviousAnswerStrategy(),
        new CheatingStrategy(),
        new FlipPreviousAnswerStrategy(),
        new NickStrategy(),
    };

    //Play each strategy against itself and all others
    var results = strategies.Select(strat1 =>
    {
        var games = strategies.Select(strat2 => 
        {
            return gameFactory.RunGame(strat1, strat2);
        });

        var totalScore = games.Sum(game => game.GetPlayer1Score());
        return new KeyValuePair<string, int>(strat1.Author, totalScore);
    });

    foreach(var result in results.OrderBy(r => r.Value))
    {
        Console.WriteLine($"{result.Key} -- {result.Value}");
    }
}

