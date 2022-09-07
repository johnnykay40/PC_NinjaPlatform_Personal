using System;
using UnityEngine;

public class PlayerVerifyDirection : MonoBehaviour
{
    internal static event Action<int> OnRotationPlayer;
    internal static event Action<bool> OnAnimRunning;

    private PlayerMovement playerMovement;
    private PlayerRotation playerRotation;

    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerRotation = FindObjectOfType<PlayerRotation>();
    }


    private void Update()
    {
        VerifyDirection();
    }
    private void VerifyDirection()
    {
        if (playerMovement.displacement.z == 0f)
        {
            OnAnimRunning?.Invoke(false);
        }
        if (playerMovement.displacement.z >= 0.01f)
        {
            transform.Translate(playerMovement.displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerForward);
            OnAnimRunning?.Invoke(true);
        }
        if (playerMovement.displacement.z <= -0.01f)
        {
            transform.Translate(-playerMovement.displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerBack);
            OnAnimRunning?.Invoke(true);
        }
    }
    
    // With Singleton
    //private void VerifyDirection()
    //{
    //    if (PlayerMovement.Instance.displacement.z == 0f)
    //    {
    //        OnAnimRunning?.Invoke(false);
    //    }
    //    if (PlayerMovement.Instance.displacement.z >= 0.01f)
    //    {
    //        transform.Translate(PlayerMovement.Instance.displacement);
    //        OnRotationPlayer?.Invoke(PlayerRotation.Instance.newRotationPlayerForward);
    //        OnAnimRunning?.Invoke(true);
    //    }
    //    if (PlayerMovement.Instance.displacement.z <= -0.01f)
    //    {
    //        transform.Translate(-PlayerMovement.Instance.displacement);
    //        OnRotationPlayer?.Invoke(PlayerRotation.Instance.newRotationPlayerBack);
    //        OnAnimRunning?.Invoke(true);
    //    }
    //}


}