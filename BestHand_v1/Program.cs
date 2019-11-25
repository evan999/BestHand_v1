using System;

namespace BestHand_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //Card card = game.DrawCard();
            game.ShuffleDeck();
            //game.GenerateHand();
            
            //Console.WriteLine(card.face + " " + card.suit);


        }
    }
}
