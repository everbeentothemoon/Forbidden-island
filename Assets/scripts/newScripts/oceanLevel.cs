using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oceanLevel : MonoBehaviour
{
    public GameObject level;
    public float deadlyLevel = 10f;
    public float currentWaterLevel = 0f;
    public Vector3  waterRiseCardPos = Vector3.zero;
    public GameObject waterRiseCard;
    bool waterRise = false;
    public GameObject gameOver;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {   
        if (waterRise == true)
        {
            currentWaterLevel += 1;
            //change this once you have the script for sinking the islands
             if (currentWaterLevel == 3f)
             {
                 
             }

            if (currentWaterLevel == 6f)
            {

            }

            if (currentWaterLevel == 8f)
            {

            }

            //this is for gameover my G, youll need to change it also
            if (currentWaterLevel == deadlyLevel)
            {

                gameOver.SetActive(true);
            }
        }
        if (waterRise == true)
        {
            rb.position = new Vector2(transform.position.x, transform.position.y + 2f);
            waterRise = false;
        }
    }
}
