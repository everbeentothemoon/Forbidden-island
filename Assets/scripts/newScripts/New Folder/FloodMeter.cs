using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodMeter : MonoBehaviour
{
    public GameObject objectToMove; // Object to be moved
    public List<Transform> targetPositions; // List of target positions (game objects)

    private int currentIndex = 0; // Current index of the target position
    public bool shouldMove = false; // Flag to indicate if the object should move

    private void Start()
    {
        if (objectToMove == null || targetPositions.Count == 0)
        {
            Debug.LogError("Object to move or target positions are not assigned!");
        }
    }

    private void Update()
    {
        if (shouldMove)
        {
            // Move the object towards the current target position
            MoveObject(objectToMove, targetPositions[currentIndex].position);
        }
    }

    private void MoveObject(GameObject obj, Vector3 targetPosition)
    {
        // Move the object towards the target position
        obj.transform.position = Vector3.MoveTowards(obj.transform.position, targetPosition, Time.deltaTime * 5f);

        // Check if the object has reached the target position
        if (obj.transform.position == targetPosition)
        {
            // Move to the next target position in the list
            currentIndex++;

            // Check if all target positions have been reached
            if (currentIndex >= targetPositions.Count)
            {
                // Reset the index to loop back to the beginning
                currentIndex = 0;

                // Stop moving the object
                shouldMove = false;
            }
        }
    }

    public void StartMoving()
    {
        shouldMove = true;
    }
}
