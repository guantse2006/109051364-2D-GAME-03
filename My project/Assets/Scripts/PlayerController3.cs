using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    public Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;

    public bool isOnGround = true;

    public int twiceJump = 0;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity = Physics.gravity * gravityMod;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && twiceJump < 2)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isOnGround = false; //
            twiceJump++;
            print("¸õªº¦¸¼Æ: " + twiceJump);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        twiceJump = 0;
    }
}
