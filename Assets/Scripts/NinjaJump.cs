using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaJump : MonoBehaviour
{
    [SerializeField] Vector3 jumpVector;

    Rigidbody myRigidbody;

    bool canJump = false;
    float xVelocityAtEnter;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = jumpVector;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            Jump();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canJump = true;
        xVelocityAtEnter = myRigidbody.velocity.x;
    }

    void Jump()
    {
        myRigidbody.velocity = new Vector3(jumpVector.x * -Mathf.Sign(xVelocityAtEnter), jumpVector.y, jumpVector.z);
        canJump = false;
    }


}
