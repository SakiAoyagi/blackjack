/// <summary>
/// ゲームの進行を管理するクラス
/// </summary>
public class GameManager
{
    /// <summary>
    /// ゲームで使用するデッキ
    /// </summary>
    private Deck Deck;

    /// <summary>
    /// プレイヤーの手札
    /// </summary>
    private List<Card> PlayerHand;

    /// <summary>
    /// ディーラーの手札
    /// </summary>
    private List<Card> DealerHand;

    /// <summary>
    /// コンストラクタ:デッキと手札を初期化
    /// </summary>
    public GameManager()
    {
        Deck = new Deck();
        PlayerHand = new List<Card>();
        DealerHand = new List<Card>();
    }
    /// <summary>
    /// 指定の枚数を手札に配る
    /// </summary>
    private void DealCards(List<Card> hand, int count)
    {
        for(int cardIndex = 0; cardIndex < count; cardIndex++)
        {
            hand.Add(Deck.DrawCard());
        }
    }

    /// <summary>
    /// ゲームをスタートさせるメソッド
    /// </summary>
    public void StartGame()
    {
        // プレイヤーに2枚
        DealCards(PlayerHand, 2);
        // ディーラーに2枚
        DealCards(DealerHand, 2);
        // プレイヤーの手札を表示する
        Console.WriteLine("プレイヤーの手札");
        foreach (Card card in PlayerHand)
        {
            Console.WriteLine(card);
        }
        ShowDealerHand();
    }

    /// <summary>
    /// ディーラーの手札を表示する
    /// </summary>
    private void ShowDealerHand()
    {
        var dealerHandMessage = new System.Text.StringBuilder();
        Console.WriteLine("ディーラーの手札: ");
        Console.WriteLine(DealerHand[0]);
        Console.WriteLine("もう1枚は伏せられています");

        Console.WriteLine(dealerHandMessage.ToString());
    }  
}