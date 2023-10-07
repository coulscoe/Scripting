using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject lazerBolt;
    public GameObject pickup;
    public int invent =0;

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        //moves the player character left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //stops the player from leaving the left side of the screen
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //stops the player from leaving the right side of the screen
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // input register. If space bar is pressed down, then the following action will occur, firing a lazerbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //create lazerBolt at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
        //if invent is greater than 0, then it will display the amount it has.
        if(invent > 0)
        {
            print("Items in the inventory:" +invent);
        }
    }
    //deletes any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        // if the game object is the pickup item it will add a number to the inventory.
        if (pickup)
        {
            invent++;
        }
    }
    

    
}
