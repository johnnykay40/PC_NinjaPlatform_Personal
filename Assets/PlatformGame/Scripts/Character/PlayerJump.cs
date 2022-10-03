using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    internal static event Action OnAnimJump;

    private PlayerCheckGround playerCheckGround;

    [Header("Values")]
    [Range(0, 10)]
    [SerializeField] private float forceImpulse;

    private Rigidbody rigidbodyPlayer;

    private void Awake()
    {
        playerCheckGround = FindObjectOfType<PlayerCheckGround>();
        rigidbodyPlayer = FindObjectOfType<Rigidbody>();
    }

    private void Update() => OnJump();
 
    private void OnJump()
    {
        if(playerCheckGround.isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerManager.playerManager.statePlayer = PlayerManager.StatePlayer.jump;

                var newVelocity = new Vector3(0, forceImpulse, 0);
                rigidbodyPlayer.velocity += newVelocity;

                OnAnimJump?.Invoke();
            }            
        }
    }
}
