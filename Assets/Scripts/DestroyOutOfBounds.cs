using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // boundaries
    private float bottomBound = -10.0f;
    private float horizontalBound = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // destroy animals that reach the bottom bound
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            // indicate the game is over in the console
            Debug.Log("Game Over!");

        }
        // destroy animals that reach the left or right horizontal bounds
        if (transform.position.x > horizontalBound || transform.position.x < -horizontalBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }


        // NOTES:
        // Destroy() is a Unity method that removes a game object from the scene
        // gameObject is a reference to the current object the script is attached to
        
    }
}
