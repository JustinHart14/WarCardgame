using System;
namespace Assignment_1
{
    public class Card
    {   public readonly string _suit;
        public readonly int _rank;

        public Card(string Suit, int Rank) //creates a card with suit and rank
        {
            _suit = Suit;
            _rank = Rank;
        }
    
        public void Show()
        {
            Console.Write($"[{this._rank},{this._suit}]");
        }
        public int Compare(Card otherCard) //Compare the value of two cards. Returns 1 if given card is smaller, 0 if they are the same, -1 if the given card is larger.
        {
            try
            {
                if (this._rank == 1 && otherCard._rank != 1) return 1;
                else if (this._rank != 1 && otherCard._rank == 1) return -1;
                else if (this._rank > otherCard._rank) return 1;
                else if (this._rank < otherCard._rank) return -1;
                else return 0;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();


        
                
                

            }
        }
    }
}
