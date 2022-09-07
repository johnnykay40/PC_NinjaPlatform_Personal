using UnityEngine;

public class PlayerPowerUps : MonoBehaviour
{
    public enum TypePlayerPowerUps
    {
        none, shootStar, dash, swim, hang
    }

    public TypePlayerPowerUps typePlayerPowerUps;

    private void OnEnable()
    {
        TypeOfPowerUps.OnInvokePowerUps += PowerUpsEquals;
    }

    private void PowerUpsEquals(SOPowerUps sOPowerUps) 
    {
        typePlayerPowerUps = (TypePlayerPowerUps)sOPowerUps.typePowerUps;
    }

    private void OnDisable()
    {
        TypeOfPowerUps.OnInvokePowerUps -= PowerUpsEquals;
    }
}
