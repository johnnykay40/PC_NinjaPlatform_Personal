using UnityEngine;

[CreateAssetMenu(menuName = "SOPowerUps")] 


public class SOPowerUps : ScriptableObject
{    
    public enum TypePowerUps
    {
        none, shootStar, dash, swim, hang
    }

    public TypePowerUps typePowerUps;
}