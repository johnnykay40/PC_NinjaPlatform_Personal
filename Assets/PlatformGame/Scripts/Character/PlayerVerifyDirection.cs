using System;
using UnityEngine;

public class PlayerVerifyDirection : MonoBehaviour
{
    internal static event Action<int> OnRotationPlayer;
    internal static event Action<bool> OnAnimRunning;
    internal static event Action<bool> OnAnimSwimming;
    
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
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.running)
            {
                OnAnimRunning?.Invoke(false); 
            }
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.swim)
            {
                OnAnimSwimming?.Invoke(false);
            }
        }
        if (playerMovement.displacement.z >= 0.01f)
        {
            transform.Translate(playerMovement.displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerForward);
            
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.running)
            {
                OnAnimRunning?.Invoke(true);
            }
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.swim)
            {
                OnAnimSwimming?.Invoke(true);
            }
        }
        if (playerMovement.displacement.z <= -0.01f)
        {
            transform.Translate(-playerMovement.displacement);
            OnRotationPlayer?.Invoke(playerRotation.newRotationPlayerBack);
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.running)
            {
                OnAnimRunning?.Invoke(true);
            }
            if (PlayerManager.playerManager.statePlayer == PlayerManager.StatePlayer.swim)
            {
                OnAnimSwimming?.Invoke(true);
            }
        }
    }
}