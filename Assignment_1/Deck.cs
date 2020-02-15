using System;
namespace Assignment_1
{
    public class Deck
    {
        private int _sizeofDeck;
        private Card[] _deck;
        private int _location;

        public Deck() //Creates an empty deck of size 52.
        { 
            _deck = new Card[52];
        }

        public Deck(bool flag) //Creates a new deck, if given true, populates the deck, if false the deck will be empty.
        {
            if (flag == true)
            {
                _sizeofDeck = 52;
                _deck = new Card[_sizeofDeck];
                string[] suits = { "D", "H", "C", "S" };
                for (int i = 0; i < suits.Length; i++)
                {
                    for (int j = 1; j < 14; j++)
                    {
                        _deck[_location] = new Card(suits[i], j);
                        _location++;

                    }

                }
            }
            else _deck = new Card[_sizeofDeck];
        }

        public void Show()//prints all the cards in the deck.
        {
            for (int i = 0; i < this._sizeofDeck; i++)
            {
                _deck[i].Show();
            }
        }

        private void ShiftRight() //shifts the cards in the deck to the right for the AddCard Method.
        {
            try
            {
                for (int i = _sizeofDeck; i > 0; i--)
                {
                    _deck[i] = _deck[i - 1];


                }
            }
            catch (Exception)
            {
                if (!(_sizeofDeck < 52))
                {
                        throw new Exception("The deck is full");
                }

            }
        }

        public void AddCard(Card cardtoAdd) //Adds the provided card to the bottom of the deck using the ShiftRight method.
        {
            try
            {
                this.ShiftRight();
                this._deck[0] = cardtoAdd;
                this._sizeofDeck++;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
            catch (Exception)
            {
                if (!(_sizeofDeck < 52)) { throw new Exception(); }
            }

        }

        public void Shuffle() //Shuffles the cards in the deck.
        {

            Random rng = new Random();
            int n = _sizeofDeck;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = _deck[k];
                _deck[k] = _deck[n];
                _deck[n] = temp;
            }

        }

        public Card Deal() //Returns the top card of the deck, and decrements the size of the deck by 1.
        {    int lastplace = _sizeofDeck - 1;
             Card CardtoDeal = _deck[lastplace];
             lastplace--;
             _sizeofDeck--;

            if (_sizeofDeck >= 0)
            {
                return CardtoDeal;
            }



            else throw new Exception("Deck is empty");
            
        }

        public int GetSize()
        {
            return _sizeofDeck;
        }

        public int GetValue() //returns the sum of all ranks of cards in the deck.
        {
            int sum = 0;
            for (int i = 0; i < _sizeofDeck; i++)
            {
                sum += _deck[i]._rank;
            }
            return sum;
        }


    }
}

