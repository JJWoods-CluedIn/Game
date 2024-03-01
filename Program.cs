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
        new Oleks111(),
        new Oleks112(),
        new Oleks113(),
        new Oleks114(),
        new Oleks115(),
        new Oleks116(),
        new Oleks117(),
        new Oleks118(),
        new Oleks119(),
        new Oleks120(),
        new Oleks121(),
        new Oleks122(),
        new Oleks123(),
        new Oleks124(),
        new Oleks125(),
        new Oleks126(),
        new Oleks127(),
        new Oleks128(),
        new Oleks129(),
        new Oleks130(),
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

