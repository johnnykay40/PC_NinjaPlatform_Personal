using System;
using UnityEngine;


public class TypeOfPowerUps : MonoBehaviour
{
    internal static event Action<SOPowerUps> OnInvokePowerUps;

    [SerializeField] internal SOPowerUps sOPowerUps;

    private PlayerPowerUps playerPowerUps;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPowerUps = other.GetComponent<PlayerPowerUps>();
            OnInvokePowerUps?.Invoke(sOPowerUps);
            playerPowerUps.sOPowerUps = sOPowerUps;
            playerPowerUps.sOPowerUps.isPowerUp = true;
        }        
    }
}
