using UnityEngine;

public class PlayerRotation : MonoBehaviour 
{
    [SerializeField] internal int newRotationPlayerForward;
    [SerializeField] internal int newRotationPlayerBack;

    private void OnEnable()
    {
        PlayerMovement.OnRotationPlayer += RotationPlayer;
        SwitchRotationPlayer.OnRotatePlayer += RotationPlayer;
    }

    private void RotationPlayer(int myRotation)
    { 
        transform.localRotation = Quaternion.Euler(0, myRotation, 0);
    }

    private void OnDisable()
    {
        PlayerMovement.OnRotationPlayer -= RotationPlayer;
        SwitchRotationPlayer.OnRotatePlayer -= RotationPlayer;
    }
}
