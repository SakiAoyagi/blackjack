class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        deck.Shuffle();

        Player player = new Player();

        // 最初にカードを2枚配る
        player.AddCard(deck.DrawCard());
        player.AddCard(deck.DrawCard());

        // プレイヤーのターン開始（デッキを渡す）
        player.PlayerTurn(deck);
    }
}