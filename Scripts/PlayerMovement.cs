using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   /* public*/ float horizontalInput;
    /*public*/ float verticalInput;

    public float moveSpeed = 10f;
    public float turnSpeed = 81f;

    private void Start()
    {
        
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime  * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
