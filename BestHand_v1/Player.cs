using System;
using System.Collections.Generic;
using System.Text;

namespace BestHand_v1
{
    public class Player
    {
        List<Player> players = new List<Player>();
        List<Card> hand = new List<Card>();
        int maxPlayers = 4;
        //int numberOfPlayers = players.Count;
        public string Name { get; set; }
        public int score;

        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }


    }
}
