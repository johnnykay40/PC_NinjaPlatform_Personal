using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float distanceToCover;
    [SerializeField] private float platformSpeed;

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }


    private void Update()
    {
        Vector3 newPositionPlatform = startingPosition;
        newPositionPlatform.z += distanceToCover * Mathf.Sin(Time.time * platformSpeed);
        transform.position = newPositionPlatform;       
        
    }
}
