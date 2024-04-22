using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float movingSpeed = 20.0f; 
    private float xRangeLeft = -2.6f;
    private float xRangeRight = 1.7f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHorizontalInput();
    }

    //Method to control user to Left or Right by pressing Left/Right key
    void PlayerHorizontalInput()
    {
         if (transform.position.z < xRangeLeft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xRangeLeft);
        }

        if (transform.position.z > xRangeRight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xRangeRight);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * movingSpeed * horizontalInput);
    }
}
