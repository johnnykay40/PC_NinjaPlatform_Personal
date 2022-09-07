using System;
using UnityEngine;


public class TypeOfPowerUps : MonoBehaviour
{
    internal static event Action<SOPowerUps> OnInvokePowerUps;

    [SerializeField] internal SOPowerUps sOPowerUps;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnInvokePowerUps?.Invoke(sOPowerUps);
        }        
    }
}
