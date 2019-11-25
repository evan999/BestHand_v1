using System;
using System.Collections.Generic;
using System.Text;

namespace BestHand_v1
{
    public class Deck
    {
        Random random = new Random();
        public List<Card> Cards { get; private set; }
        
        public Deck()
        {
            Cards = new List<Card>();
        }

    }
}
