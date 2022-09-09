using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    
    [Header("Parameter's")]
    [Range(0,50)]
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody rigidbodyPlayer;
    
    
    internal Vector3 displacement;
    private float horizontalMovement;         

    private void Update()
    {        
        PlayerMove();        
    }

    private void PlayerMove()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        displacement.Set(0f, 0f, horizontalMovement);

        displacement = displacement.normalized * playerSpeed * Time.deltaTime;

        rigidbodyPlayer.MovePosition(transform.position + displacement);
    }

}
