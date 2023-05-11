using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // player speed
    public float speed = 10.0f;

    // userinput
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get userinput
        horizontalInput = Input.GetAxis("Horizontal");

        // make player move left and right
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // ensure player stays within the specified bounds and spawn player to the edge if they attempt to go past the restrictions

        // left bound
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        // right bound
        else if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        
    }
}
