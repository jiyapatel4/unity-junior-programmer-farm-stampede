using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // player stats
    private int lives = 3;
    static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // overide methods and destory objects upon collision
    private void OnTriggerEnter(Collider other)
    {
        // if the collision trigger is the player, then just destroy the animal
        if (gameObject.tag == "Player" && other.tag != "Pizza")
        {
            Destroy(other.gameObject);
            Debug.Log("Game Over!");

            lives--;
            Debug.Log("Lives: " + lives);

        }
        // if the collision trigger is the pizza, then destroy both the pizza and animal
        else if (gameObject.tag == "Pizza" && other.tag != "Player")
        {
            Destroy(GameObject.FindWithTag("Pizza"));
            Destroy(other.gameObject);

            score++;
            Debug.Log("Score: " + score);

        }
          
    }
}
