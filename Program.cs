class Program
{
    static void Main(string[] args)
    {
        GameManager game = new GameManager();

       game.StartGame();
       game.PlayerTurn();
       game.DealerTurn();
       game.JudgeWinner();
    }
}