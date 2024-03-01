public interface IGameFactory
{
    TurnLog RunGame(IStrategy player1, IStrategy player2);
}