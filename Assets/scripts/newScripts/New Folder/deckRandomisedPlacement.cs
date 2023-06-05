using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deckRandomisedPlacement : MonoBehaviour
{
    public GameObject[] objectsToPlace; // Array of game objects to be placed
    public Transform[] placementTransforms; // Array of transforms where objects can be placed

    private void Start()
    {
        PlaceObjectsRandomly();
    }

    private void PlaceObjectsRandomly()
    {
        // Check if the number of objects and placement transforms match
        if (objectsToPlace.Length != placementTransforms.Length)
        {
            Debug.LogError("Number of objects and placement transforms do not match.");
            return;
        }

        // Randomly shuffle the placement transforms array
        ShuffleTransformsArray();

        // Place each object on the randomized placement transforms
        for (int i = 0; i < objectsToPlace.Length; i++)
        {
            GameObject objectToPlace = objectsToPlace[i];
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
}
