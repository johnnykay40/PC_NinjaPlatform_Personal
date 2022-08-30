using UnityEngine;
using System;

public class SwitchRotationPlayer : MonoBehaviour
{
    internal static event Action<int> OnRotatePlayer;
    internal static event Action<int> OnCheckCineMachine;

    private PlayerRotation playerRotation;

    [Header("Camera index")]
    [SerializeField] private int index;

    [Header("Player Rotation")]
    [SerializeField] private int _newRotationPlayerForward;
    [SerializeField] private int _newRotationPlayerBack;

    private void Awake()
    {
        playerRotation = FindObjectOfType<PlayerRotation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerRotation.newRotationPlayerBack = _newRotationPlayerBack;
            playerRotation.newRotationPlayerForward = _newRotationPlayerForward;

            OnRotatePlayer?.Invoke(playerRotation.newRotationPlayerForward);
            OnCheckCineMachine?.Invoke(index);
        }
    }
}
