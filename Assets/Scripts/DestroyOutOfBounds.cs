using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // top boundary
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.z < bottomBound)
        {
            // display message in console when an animal passes the player
            Debug.Log("Game Over!");

            Destroy(gameObject);
        }

        // NOTES:
        // Destroy() is a Unity method that removes a game object from the scene
        // gameObject is a reference to the current object the script is attached to
        
    }
}
