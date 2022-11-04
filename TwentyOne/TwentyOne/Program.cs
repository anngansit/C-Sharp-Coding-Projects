using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            ////for reference
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob", };
            //game.ListPlayers();
            //Console.ReadLine();

            ////Enum
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingvalue = (int)Suit.Diamonds;

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            ////game = game + player;
            ////game = game - player;
            //game += player;
            //game -= player;


            //Deck deck = new Deck();

            //int counter = 0;

            //using Lambda
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //Another Lambda example
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Another Lambda example
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //int sum = numberList.Sum();
            //int sum = numberList.Sum(x => x + 5);
            //int sum = numberList.Max();
            //int sum = numberList.Min();
            //int sum = numberList.Where(x => x > 20).Sum();

            //Console.WriteLine(sum);

                                       

            ////Using foreach loop
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);


            //deck.Shuffle(3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


            //}

            ////public static Deck Shuffle(Deck deck, int times)
            ////{
            ////    for (int i = 0; i < times; i++)
            ////    {
            ////        deck = Shuffle(deck);
            ////    }
            ////    return deck;
            //}


        }

      

    }
}
