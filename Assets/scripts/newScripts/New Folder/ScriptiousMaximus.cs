using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptiousMaximus : MonoBehaviour
{
    public List<GameObject> players; // Array of player game objects
    public int currentPlayerIndex; // Index of the current player
    public int actionsRemaining; // Number of actions remaining for the current player
    private bool isGameOver; // Flag to indicate if the game is over
    public int playerCount;
    public List<GameObject> playersCards;

    public List<GameObject> cards;
    public List<GameObject> cards2;
    public GameObject pickupCardsConfirm;

    public int pIndex;
    GameObject newObj;


    private void Start()
    {
        currentPlayerIndex = 0; // Start with the first player
        actionsRemaining = 3; // Set initial actions for each player
        isGameOver = false; // Initialize game over flag
        playerCount = players.Count;

        pickupCardsConfirm.SetActive(false);
        cards2 = new List<GameObject>(cards);

        foreach (GameObject obj in playersCards)
        {
            obj.SetActive(false);
        }
    }

    

    private void Update()
    {
        // Check for input to perform an action if the game is not over
        if (!isGameOver && Input.GetMouseButtonDown(0))
        {
            PerformAction();
        }

        if (cards.Count == 0)
        {
            cards.Clear();
            cards.AddRange(cards2);

            // Refill FloodCards with the contents of FloodCards2
            //FloodCards = new List<GameObject>(FloodCards2);
        }

        if (actionsRemaining == 0)
        {
            PickingUpCards();
            PickingUpCards();
            return;
        }

    }

    private void PerformAction()
    {
        // Check if the current player has actions remaining
        if (actionsRemaining > 0)
        {
            // Perform an action for the current player
            Debug.Log("Player " + (currentPlayerIndex + 1) + " performs an action. Actions remaining: " + actionsRemaining);



            // Decrease the number of actions remaining
            actionsRemaining--;
        }
        else
        {
            // Move to the next player's turn or loop back to the first player
            currentPlayerIndex++;
            if (currentPlayerIndex >= players.Count)
            {
                currentPlayerIndex = 0; // Loop back to the first player if all players have taken a turn
            }

            // Reset the actions for the current player
            actionsRemaining = 3;

            Debug.Log("End of Player " + (currentPlayerIndex + 1) + "'s turn.");

            // Check if the lose condition is true
            if (IsGameOverConditionMet())
            {
                isGameOver = true;
                Debug.Log("Game Over");
            }
        }
    }

    private bool IsGameOverConditionMet()
    {
        // Add your own logic here to determine if the lose condition is true
        // Example: check if a player has lost all their health or if a certain condition is met
        // Return true if the lose condition is met, false otherwise
        return false;
    }


    public void PickToPickUpCards()
    {
        pickupCardsConfirm.SetActive(true);



    }

    public void PickingUpCards()
    {
        pIndex = Random.Range(0, cards.Count);
        newObj = Instantiate(cards[pIndex]); // Instantiate the prefab

        /*if (newObj.CompareTag("waterrise"))
        {
            
            return;
        }*/

        // Set the parent and sibling index of the picked card
        newObj.transform.SetParent(playersCards[currentPlayerIndex].transform, true);
        newObj.transform.SetSiblingIndex(0);

        // Remove the picked card from FloodCards
        cards.RemoveAt(pIndex);
        pickupCardsConfirm.SetActive(false);

        // Check if the current player has actions remaining
        if (actionsRemaining > 0)
        {
            // Perform an action for the current player
            Debug.Log("Player " + (currentPlayerIndex + 1) + " performs an action. Actions remaining: " + actionsRemaining);

            // Decrease the number of actions remaining
            actionsRemaining--;
        }
        else
        {
            // Move to the next player's turn or loop back to the first player
            int childCount = players[pIndex].transform.childCount;
            currentPlayerIndex++;
            if (currentPlayerIndex >= childCount)
            {
                currentPlayerIndex = 0;
            }
            actionsRemaining = 3;
        }
    }

    public void GivingCard(int index)
    {
        if (players[index].transform.childCount <= 5)
        {
            cards[index].transform.SetParent(players[index].transform, true);
        }


        else
        {
            Debug.Log("full or some shit");
        }
    }


}
