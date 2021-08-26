using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
    private Transform target;
    private float halfheight;
    private float halfwidth;
    void Start()
    {
        if (PlayerMovementWASD02.instance == null)
        {
            target = FindObjectOfType<PlayerMovementWASD02>().transform;
        }
        else
        {
            target = PlayerMovementWASD02.instance.transform;
        }
        halfheight = Camera.main.orthographicSize;
        halfwidth = halfheight * Camera.main.aspect;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
} 