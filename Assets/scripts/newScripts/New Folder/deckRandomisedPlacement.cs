using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deckRandomisedPlacement : MonoBehaviour
{
    public GameObject[] islandCards; // Array of game objects to be placed
    public GameObject[] sunkenCards;
    public Transform[] placementTransforms; // Array of transforms where objects can be placed
    public List<GameObject> floodDeck;
    public GameObject floodDeckdisplay;

    public void Start()
    {
        
        PlaceObjectsRandomly();
    }

    private void PlaceObjectsRandomly()
    {
        // Check if the number of objects and placement transforms match
        if (islandCards.Length != placementTransforms.Length)
        {
            Debug.LogError("Number of objects and placement transforms do not match.");
            return;
        }

        // Randomly shuffle the placement transforms array
        ShuffleTransformsArray();

        // Place each object on the randomized placement transforms
        for (int i = 0; i < islandCards.Length; i++)
        {
            GameObject objectToPlace = islandCards[i];
            Transform placementTransform = placementTransforms[i];

            Instantiate(objectToPlace, placementTransform.position, placementTransform.rotation);
        }
    }

    private void ShuffleTransformsArray()
    {
        // Fisher-Yates shuffle algorithm to randomly shuffle the placement transforms array
        for (int i = 0; i < placementTransforms.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, placementTransforms.Length);
            Transform temp = placementTransforms[i];
            placementTransforms[i] = placementTransforms[randomIndex];
            placementTransforms[randomIndex] = temp;
        }
    }

    public void CheckWhichCardsToSink(int index)
    {
        if (floodDeckdisplay)
        {
            
        }
    }

    public void FloodCardAllocation(int index)
    {
        // if (remainingActions >= 5)
        if (sunkenCards[index] == islandCards[index])
        {
            islandCards[index].SetActive(false);
            sunkenCards[index].transform.position = islandCards[index].transform.position;
        }
    }
}
