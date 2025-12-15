using System;

class Program
{
    static void Main()
    {
        Deck deck = new Deck();
        Console.WriteLine("カード枚数: " + deck.CardCount);

        Card c1 = deck.DrawCard();
        Console.WriteLine("引いたカード: " + c1);
        Console.WriteLine("残り枚数: " + deck.CardCount);
    }
}
