using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // player speed
    public float speed = 10.0f;

    // userinput
    private float horizontalInput;
    private float verticalInput;

    // player boundary ranges
    private float xRange = 10.0f;
    private float zRangeTop = 10.0f;
    private float zRangeBottom = -1.0f;

    // references original pizza prefab
    public GameObject pizzaProjectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get userinput
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // make player move left and right
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // make the player move forwards and backwards
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // ensure player stays within the specified bounds and spawn player to the edge if they attempt to go past the restrictions
        // left bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // right bound
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // top bound
        if (transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }
        // bottom bound
        else if (transform.position.z < zRangeBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBottom);
        }


        // when space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch pizza projectile
            // create instances of the prefab that spawn at the player's location and preserve the prefab orientation
            Instantiate(pizzaProjectile, transform.position, pizzaProjectile.transform.rotation);
        }
        
    }
}
