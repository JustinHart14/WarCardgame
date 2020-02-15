using System;
namespace Assignment_1
{
    public class Player
    {

        private readonly string _name;
        private Deck _playingDeck;
        private int _score;




        public Player(string Name) //Constructs a new Player with Name, and an empty deck
        {
            _name = Name;
            _playingDeck = new Deck();
        }

        public int Score() //returns the score of all cards in the deck based upon their rank.
        {
            _score = _playingDeck.GetValue();
            return _score;
        }


        public void Show() //Prints the player's name, score and cards in deck.
        { 
            Console.WriteLine($"{_name} ,{this.Score()}");
            _playingDeck.Show();
            
        }

        public bool CanPlay() //Players can't play if # of cards <1.
        { 
            return _playingDeck.GetSize() >= 1;
        }

        public void TakeCard(Card CardtoAdd) // Calls the addcard method to add the given card to the deck.
        {   
            _playingDeck.AddCard(CardtoAdd);
        }

        public Card Play() //Returns top card from playing Deck.
        {
            if (CanPlay()){
                return _playingDeck.Deal(); }
            else throw new Exception("The Deck is Empty");
        }

        public static void Winner(Player firstPlayer, Player otherPlayer) // prints the winner of the game between two players.
        {   if (firstPlayer.Score() > otherPlayer.Score())
                Console.WriteLine($"{firstPlayer._name} is the winner with a score of {firstPlayer.Score()}");
            else Console.WriteLine($"{otherPlayer._name} is the winner with a score of {otherPlayer.Score()}");
        }

    }
}
