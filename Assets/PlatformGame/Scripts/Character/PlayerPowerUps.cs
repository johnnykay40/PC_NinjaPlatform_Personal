using UnityEngine;

public class PlayerPowerUps : MonoBehaviour
{
    public SOPowerUps sOPowerUps;

    private PlayerDash playerDash;

    private void Awake()
    {
        playerDash = FindObjectOfType<PlayerDash>();
    }

    private void Update()
    {
        PowerUp();
    }

    private void PowerUp()
    {
        if (sOPowerUps != null)
        {
            if(sOPowerUps.isPowerUp)
            {
                if (Input.GetMouseButton(0))
                {
                    switch (sOPowerUps.typePowerUp)
                    {
                        case SOPowerUps.TypePowerUp.dash:
                            playerDash.CallDash();
                            break;
                        case SOPowerUps.TypePowerUp.shootStar:
                            Debug.Log("Shoot Star");
                            break;
                        case SOPowerUps.TypePowerUp.swim:
                            break;
                        case SOPowerUps.TypePowerUp.hang:
                            break;
                    }
                }
            }
        }
    }
}
