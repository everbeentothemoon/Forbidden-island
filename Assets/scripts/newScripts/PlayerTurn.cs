using System;
using System.Collections.Generic;
using UnityEngine;

/*public class PlayerTurn : MonoBehaviour
{
    private List<Player> players;
    private int currentTurn;
    private bool gameOver;

    public void Play()
    {
        while (!gameOver)
        {
            Console.WriteLine("Turn " + currentTurn);
            foreach (Player player in players)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("What would you like to do? (1 = move, 2 = trade cards, 3 = revive sunken island board piece)");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            player.Move();
                            break;
                        case 2:
                            player.TradeCards();
                            break;
                        case 3:
                            player.ReviveLostBoardPiece();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
            currentTurn++;
        }
    }
}

public class Player
{
    public string Name { get; private set; }
    private int health;
    private int position;
    private List<Card> hand;
    private List<BoardPiece> lostPieces;

    public Player(string name, int health, int position, List<Card> hand, List<BoardPiece> lostPieces)
    {
        Name = name;
        this.health = health;
        this.position = position;
        this.hand = hand;
        this.lostPieces = lostPieces;
    }

    public void Move()
    {
        
    }

    public void TradeCards()
    {
        
    }

    public void ReviveLostBoardPiece()
    {
        
    }


public class Card
{
    public string Name { get; private set; }
    private int power;

    public Card(string name, int power)
    {
        Name = name;
        this.power = power;
    }

    public int GetPower()
    {
        return power;
    }
}

public class BoardPiece
{
    public string Name { get; private set; }

    public BoardPiece(string name)
    {
        Name = name;
    }
}
*/
