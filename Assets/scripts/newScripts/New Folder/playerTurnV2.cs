using UnityEngine;

public class PlayerTurnV2 : MonoBehaviour
{
    public GameObject[] players; // Array of player game objects
    private int currentPlayerIndex; // Index of the current player
    private int actionsRemaining; // Number of actions remaining for the current player

    private void Start()
    {
        currentPlayerIndex = 0; // Start with the first player
        actionsRemaining = 3; // Set initial actions for each player
    }

    private void Update()
    {
        // Check for player input to perform actions
        if (Input.GetMouseButtonDown(0)) // 0 represents the left mouse button
        {
            PerformAction();
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
            // Move to the next player's turn
            EndTurn();
        }
    }

    private void EndTurn()
    {
        // Reset the actions for the current player
        actionsRemaining = 3;

        // Move to the next player
        currentPlayerIndex++;
        if (currentPlayerIndex >= players.Length)
        {
            currentPlayerIndex = 0; // Start from the first player if all players have taken a turn
        }

        Debug.Log("End of Player " + currentPlayerIndex + "'s turn. Next player: Player " + (currentPlayerIndex + 1));
    }
}
