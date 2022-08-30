using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    internal static event Action<int> OnRotationPlayer;
    internal static event Action<bool> OnAnimRunning;

    private PlayerRotation playerRotation;

    [Header("Parameter's")]
    [Range(0,50)]
    [SerializeField] private float playerSpeed;
     

    internal Vector3 displacement;
    private float horizontalMovement;

    private void Awake()
    {
        playerRotation = FindObjectOfType<PlayerRotation>();
    }

    private void Update()
    {
        PlayerMove();
        VerifyDirection();
    }

    private void PlayerMove()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        displacement.Set(0f, 0f, horizontalMovement);

        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
    }

    private void VerifyDirection()
    {
        if (displacement.z == 0f)
        {
            OnAnimRunning?.Invoke(false);
        }
        if (displacement.z >= 0.01f)
        {
            transform.Translate(displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerForward);
            OnAnimRunning?.Invoke(true);
        }
        if (displacement.z <= -0.01f)
        {
            transform.Translate(-displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerBack);
            OnAnimRunning?.Invoke(true);
        }
    }
}
