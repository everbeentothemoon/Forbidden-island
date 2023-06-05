using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/*public class PickUpCards : MonoBehaviour
{
    public class Card
    {
        public string Name { get; private set; }

        public Card(string name)
        {
            Name = name;
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private int index;

        public Deck(List<Card> cards)
        {
            this.cards = cards;
            index = 0;
        }

        public Card DrawCard()
        {
            if (index >= cards.Count)
            {
                Shuffle();
                index = 0;
            }
            Card card = cards[index];
            index++;
            return card;
        }

        private void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }
    }

    public class Player
    {
        public string Name { get; private set; }
        private List<Card> hand;

        public Player(string name)
        {
            Name = name;
            hand = new List<Card>();
        }

        public void DrawCard(Deck deck)
        {
            if (hand.Count >= 5)
            {
                Console.WriteLine("Player " + Name + " cannot draw a card because their hand is full.");
                return;
            }

            Card card = deck.DrawCard();
            hand.Add(card);
            Console.WriteLine("Player " + Name + " drew " + card.Name + ".");
        }

        public void DiscardCard()
        {
            Console.WriteLine("Player " + Name + ", choose a card to discard:");

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + hand[i].Name);
            }

            int choice = -1;
            while (choice < 1 || choice > hand.Count)
            {
                Console.Write("Enter a number between 1 and " + hand.Count + ": ");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);
            }

            hand.RemoveAt(choice - 1);
        }

        public void DrawCard(Deck deck)
        {
            Card card = deck.DrawCard();
            hand.Add(card);
            Console.WriteLine("Player " + Name + " drew " + card.Name + ".");
        }
    }

    public class Game
    {
        private List<Player> players;
        private Deck deck;

        public Game(List<Player> players, List<Card> cards)
        {
            this.players = players;
            deck = new Deck(cards);
        }

        public void Play()
        {
            while (true)
            {
                foreach (Player player in players)
                {
                    player.DrawCard(deck);
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Ace of Hearts"));
            cards.Add(new Card("King of Hearts"));
            cards.Add(new Card("Queen of Hearts"));
            cards.Add(new Card("Jack of Hearts"));
            cards.Add(new Card("Ten of Hearts"));
            cards.Add(new Card("Nine of Hearts"));
            cards.Add(new Card("Eight of Hearts"));
            cards.Add(new Card("Seven of Hearts"));
            cards.Add(new Card("Six of Hearts"));
            cards.Add(new Card("Five of Hearts"));
            cards.Add(new Card("Four of Hearts"));
            cards.Add(new Card("Three of Hearts"));
            cards.Add(new Card("Two of Hearts"));

            List<Player> players = new List<Player>();
            players.Add(new Player("Player 1"));
            players.Add(new Player("Player 2"));

            Game game = new Game(players, cards);
            game.Play();
        }
    }
}*/