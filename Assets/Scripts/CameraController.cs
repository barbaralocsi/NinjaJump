using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float smoothTime = 0.3f;

    GameObject player;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        player = FindObjectOfType<NinjaJump>().gameObject;
    }

    void Update()
    {
        // Matching y coordinate to player's y coordinate.
        Vector3 targetPosition = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
