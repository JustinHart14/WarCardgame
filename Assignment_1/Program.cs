using System;

namespace Assignment_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int turn = 0;
            
            Deck MainDeck = new Deck(true);
            MainDeck.Shuffle();
            
            Player Playerone = new Player("Player One");
            Player Playertwo = new Player("Player Two");
  
            for (int i =MainDeck.GetSize(); i >0; i--)
            {
                if (i % 2 == 0)
                {
                    Playerone.TakeCard(MainDeck.Deal());
                }
                else Playertwo.TakeCard(MainDeck.Deal());
            }
            
           while (turn < 101)
            {
                Card p1Dealt = Playerone.Play();
                Card p2Dealt = Playertwo.Play();
                switch(p1Dealt.Compare(p2Dealt)) // Compares Player1's deck to Player 2's. The winner takes both cards. In the event of a tie, each player takes their card back.
                {
                    case (1): Playerone.TakeCard(p1Dealt);
                              Playerone.TakeCard(p2Dealt);
                        break;
                    case (-1): Playertwo.TakeCard(p2Dealt);
                               Playertwo.TakeCard(p1Dealt);
                        break;
                    case (0): Playerone.TakeCard(p1Dealt);
                        Playertwo.TakeCard(p2Dealt);
                        break;

                }
                turn++;
            }

            Playerone.Show();
            Console.WriteLine();
            Playertwo.Show();
            Console.WriteLine();
            Player.Winner(Playerone, Playertwo);//Returns the winner of the game.
            
            

            
            
          
               
            }

            
        }
    }


