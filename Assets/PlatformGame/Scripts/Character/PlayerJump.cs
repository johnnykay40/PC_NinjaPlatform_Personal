using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    internal static event Action OnAnimJump;

    [Header("Parameter's")]
    [SerializeField] private float forceImpulse;

    [SerializeField] private Rigidbody rigidbodyPlayer;

    private PlayerCheckGround playerCheckGround;

    private void Awake()
    {
        playerCheckGround = FindObjectOfType<PlayerCheckGround>();
    }
    private void Update()
    {
        OnJump();
    }

    private void OnJump()
    {
        if(playerCheckGround.isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var newVelocity = new Vector3(0, forceImpulse, 0);
                rigidbodyPlayer.velocity += newVelocity;

                OnAnimJump?.Invoke();
            }           
        }
    }
}
