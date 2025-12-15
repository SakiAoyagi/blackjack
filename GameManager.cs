public class GameManager
{
    private Deck deck;
    private List<Card> playerHand;
    private List<Card> dealerHand;
    // コンストラクタ
    public GameManager()
    {
        deck = new Deck();
        playerHand = new List<Card>();
        dealerHand = new List<Card>();
    }
    public void StartGame()
    {
    // プレイヤーに2枚
    playerHand.Add(deck.DrawCard());
    playerHand.Add(deck.DrawCard());
    // ディーラーに2枚
    dealerHand.Add(deck.DrawCard());
    dealerHand.Add(deck.DrawCard());

    // プレイヤーの手札を表示する
    Console.WriteLine("プレイヤーの手札");
    foreach (Card card in  playerHand)
    {
        Console.WriteLine(card);
    }
    // ディーラーの手札を表示する
    Console.WriteLine("ディーラーの手札: ");
    Console.WriteLine(dealerHand[0]);    //1枚目だけ
    Console.WriteLine("もう1枚は伏せられています");
    }
}