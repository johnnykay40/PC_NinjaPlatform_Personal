using UnityEngine;

public class PlayerRotation : MonoBehaviour 
{
    //public static PlayerRotation Instance;
    
    [SerializeField] internal int newRotationPlayerForward;
    [SerializeField] internal int newRotationPlayerBack;

    // With Singleton
    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnEnable()
    {
        PlayerVerifyDirection.OnRotationPlayer += RotationPlayer;
        SwitchRotationPlayer.OnRotatePlayer += RotationPlayer;
    }

    private void RotationPlayer(int myRotation)
    { 
        transform.localRotation = Quaternion.Euler(0, myRotation, 0);
    }

    private void OnDisable()
    {
        PlayerVerifyDirection.OnRotationPlayer -= RotationPlayer;
        SwitchRotationPlayer.OnRotatePlayer -= RotationPlayer;
    }
}
