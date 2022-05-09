using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCards
{
    class Card
    {
        string rank;
        string suit;
        bool faceUp;

        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
            faceUp = false;
        }
        public string Rank
        {
            get { return rank; }
        }
        public string Suit
            { get { return suit; } }
        public bool FaceUp
            { get { return faceUp; } }
        public void FlipOver()
        {
            faceUp = !faceUp;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            // create the cards
            Card firstCard = new Card("Ace", "Spades");
            Card secondCard = new Card("Jack", "Diamonds");
            Card thirdCard = new Card("Queen", "Hearts");
            // print the cards in reverse order
            Console.WriteLine(thirdCard.Rank + " of " + thirdCard.Suit);
            Console.WriteLine(secondCard.Rank + " of " + secondCard.Suit);
            Console.WriteLine(firstCard.Rank + " of " + firstCard.Suit);
            Console.WriteLine();
        }
    }
}
