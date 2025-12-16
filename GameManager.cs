/// <summary>
/// ゲームの進行を管理するクラス
/// </summary>
public class GameManager
{
    private Deck deck;
    private List<Card> playerHand;
    private List<Card> dealerHand;
    /// <summary>
    /// コンストラクタ:デッキと手札を初期化
    /// </summary>
    public GameManager()
    {
        deck = new Deck();
        playerHand = new List<Card>();
        dealerHand = new List<Card>();
    }
    /// <summary>
    /// 指定の枚数を手札にカードを配る
    /// </summary>
    private void DealCards(List<Card> hand, int count)
    {
        for(int i = 0; i < count; i++)
        {
            hand.Add(deck.DrawCard());
        }
    }

    /// <summary>
    /// ゲームをスタートさせるメソッド
    /// </summary>
    public void StartGame()
    {
        // プレイヤーに2枚
        DealCards(playerHand, 2);
        // ディーラーに2枚
        DealCards(dealerHand, 2);
        // プレイヤーの手札を表示する
        Console.WriteLine("プレイヤーの手札");
        foreach (Card card in  playerHand)
        {
            Console.WriteLine(card);
        }
        // ディーラーの手札を1枚だけ表示する
        Console.WriteLine("ディーラーの手札: ");
        Console.WriteLine(dealerHand[0]);
        Console.WriteLine("もう1枚は伏せられています");
    }
}