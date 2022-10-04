using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    [Range(0,50)]
    [SerializeField] internal float playerSpeed;

    private Rigidbody rigidbodyPlayer;
    internal Vector3 displacement;
    private float horizontalMovement;

    //Lambda
    private void Awake() => rigidbodyPlayer = GetComponent<Rigidbody>();

    private void Update() => PlayerMove();        

    private void PlayerMove()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        displacement.Set(0f, 0f, horizontalMovement);

        //First Time deltatime
        displacement = displacement.normalized * Time.deltaTime * playerSpeed;

        rigidbodyPlayer.MovePosition(transform.position + displacement);
    }
}
