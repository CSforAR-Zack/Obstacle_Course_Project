using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody rigidBody = null;


    void Start()
    {
        PrintInstructions();
        rigidBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the walls or other obstacles.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * moveSpeed;

        rigidBody.velocity = new Vector3(xValue, 0, zValue);
    }

}
