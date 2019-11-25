using System;
using System.Collections.Generic;
using System.Text;

namespace BestHand_v1
{
    public class Game : Card
    {

        //public Queue<Card> Deck { get; set; }
        public List<Card> Deck = new List<Card>(52); 
        Random random = new Random();

        public Game()
        {

        }

        public List<Card> DealHand()
        {
            //List<Card> hand = new List<Card>();

            int cardsInHand = 8;
            //List<int> drawnCardValues = new List<int>();
            List<Card> hand = new List<Card>();
            //Dictionary<int, int> hand = new Dictionary<int, int>();

           
            for (int card = 0; card < cardsInHand; card++)
            {

                Card temp = new Card(random.Next(2, 14), random.Next(0, 3)); 
                if(!hand.Contains(temp))
                {
                    hand.Add(temp);
                    Console.WriteLine(temp.face + " " + temp.suit);
                }
                
                
                /*
                if(!drawnCardValues.Contains(face))
                {
                    hand.Add(new Card(random.Next(0, 13), random.Next(0, 3)));
                    Console.WriteLine(hand[card]);
                }
                */
                
            }

            return hand;
        }

        public void ShuffleDeck(/*List<Card> Deck*/)
        {
            List<Card> shuffled = new List<Card>();
            Random random = new Random();

            /*
            
            for (int card = shuffled.Count - 1; card > 0; card++)
            {
                int rand = random.Next(card + 1);
                if(rand != card)
                {
                    Card newCard = shuffled[rand];
                }
            }
            */
            
            for(int face = 2; face <= 14; face++)
            {
                for(int suit = 0; suit <= 3; suit++)
                {
                    Card temp = new Card(face, suit);
                    Deck.Add(temp);
                    Console.WriteLine(temp.face + " " + temp.suit);
                    //Console.WriteLine(Deck[face][suit]);
                }
                //int face = random.Next(2, 14);
                //int suit = random.Next(0, 3);
                
            }
            

            //return shuffled;
        }

        public int CalculateHand(List<Card> hand)
        {
            //int cardsInHand = 8;
            int totalFaceValue = 0;


            foreach (Card card in hand)
            {
                totalFaceValue += face;
            }

            return totalFaceValue;
        }
    }
}
