using System.Text;

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
        for(int i = 0; i < count; i++)
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

        // 出力用のStringBuilderを用意
        var sb = new StringBuilder();

        // プレイヤーの手札を表示
        sb.AppendLine("プレイヤーの手札:");
        foreach (Card card in PlayerHand)
        {
            sb.AppendLine(card.ToString());
        }

        // ディーラーの手札を表示
        sb.AppendLine("ディーラーの手札:");
        sb.AppendLine(DealerHand[0].ToString());
        sb.AppendLine("もう1枚は伏せられています");

        // プレイヤーの点数を表示
        sb.AppendLine("プレイヤーの点数: " + CalculateHandValue(PlayerHand));

        // 最後にまとめて出力
        Console.WriteLine(sb.ToString());
    }
    
    /// <summary>
    /// 手札の合計点を計算するメソッド
    /// </summary>
    private int CalculateHandValue(List<Card> hand)
    {
        int total = 0;
        foreach (Card card in hand)
        {
            total += card.Value;
        }
        return total;
    }
}