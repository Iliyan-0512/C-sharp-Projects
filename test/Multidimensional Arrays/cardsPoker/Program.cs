using System;
using System.Collections.Generic;

namespace PokerGame
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private static readonly Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealOne()
        {
            if (cards.Count > 0)
            {
                Card card = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                return card;
            }
            else
            {
                throw new InvalidOperationException("No more cards in the deck.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            // Deal two cards to the player
            Console.WriteLine("Your hand:");
            Console.WriteLine(deck.DealOne());
            Console.WriteLine(deck.DealOne());

            // Deal five cards to the table
            Console.WriteLine("\nCards on the table:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(deck.DealOne());
            }

            // Here you would add logic to determine the poker hand
            Console.WriteLine("\nYour best hand: [Add logic to determine best hand]");
        }
    }
}
