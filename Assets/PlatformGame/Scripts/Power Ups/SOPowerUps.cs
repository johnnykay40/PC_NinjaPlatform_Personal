using UnityEngine;

[CreateAssetMenu(menuName = "SOPowerUps")] 
public class SOPowerUps : ScriptableObject
{    
    [SerializeField] internal bool isPowerUp;

    public enum TypePowerUp
    {
        dash, shootStar, swim, hang
    }
    public TypePowerUp typePowerUp;
}