using Game.Strategies;

Main();

void Main()
{
    var gameFactory = new GameFactory(100);

    var strategies = new List<IStrategy>
    {
        new ExampleStrategy(),
        new DefectStrategy(),
        new ChaosStrategy(),
        new RepeatOtherPlayerPreviousAnswerStrategy(),
        new AndreasStrategy(),
        new AndreasStrategy2(),
        new AndreasStrategy3(),
        new FlipPreviousAnswerStrategy(),
        new CheatingStrategy(),
        new NickStrategy(),
        new Vengefulness(),
        new KeepCooperatingStrategy(),
        new NickStrategy2(),
        new JoshStrategy(),
        
        new Oleks1(),
        new Oleks2(),
        new Oleks3(),
        new Oleks4(),
        new Oleks100(),
        new Oleks101(),
        new Oleks102(),
        new Oleks103(),
        new Oleks104(),
        new Oleks105(),
        new Oleks106(),
        new Oleks107(),
        new Oleks108(),
        new Oleks109(),
        new Oleks110(),
        new Oleks110(),
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

    foreach(var result in results.OrderByDescending(r => r.Value))
    {
        Console.WriteLine($"{result.Key,40} -- {result.Value}");
    }
}

