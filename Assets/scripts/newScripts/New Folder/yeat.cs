using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeat : MonoBehaviour
{
    public List<GameObject> FloodCards;
    public List<GameObject> FloodCards2;
    public int index;

    public List<GameObject> players;
    public int currentPlayerIndex;

    void Start()
    {
        // Create a copy of FloodCards to initialize FloodCards2
        FloodCards2 = new List<GameObject>(FloodCards);
    }

    void Update()
    {
        if (FloodCards.Count == 0)
        {
            FloodCards.Clear();
            FloodCards.AddRange(FloodCards2);

            // Refill FloodCards with the contents of FloodCards2
            //FloodCards = new List<GameObject>(FloodCards2);
        }
    }

    public void PickUpACard()
    {
        index = Random.Range(0, FloodCards.Count);


        GameObject newObj = Instantiate(FloodCards[index]); // Instantiate the prefab


        // Set the parent and sibling index of the picked card
        newObj.transform.SetParent(players[currentPlayerIndex].transform, true);
        newObj.transform.SetSiblingIndex(0);

        // Remove the picked card from FloodCards
        FloodCards.RemoveAt(index);
    }
}
