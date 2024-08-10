using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the Inspector
    public Vector3 offset; // Offset from the player

    void Start()
    {
        offset = transform.position - player.position; // Calculate initial offset
    }

    void LateUpdate()
    {
        transform.position = player.position + offset; // Update camera position
    }
}
