using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private Rigidbody rigidbodyPlayer;

    [Header("Checker")]
    [SerializeField] private bool isDashing;

    [Header("Values")]
    [SerializeField] private float dashingPowerToPlayer;
    [SerializeField] private TrailRenderer trailRenderer;

    public Vector3 directionDash;

    public PlayerPowerUps playerPowerUps;

    private WaitForSeconds delayDashTime = new WaitForSeconds(1f);

    private void FixedUpdate()
    {
        if (playerPowerUps.typePlayerPowerUps == PlayerPowerUps.TypePlayerPowerUps.dash)
        {
            if (Input.GetMouseButtonDown(0) && !isDashing)
            {
                PlayerManager.playerManager.statePlayer = PlayerManager.StatePlayer.dash;
                StartCoroutine(CheckDash());
                isDashing = true;

                if (isDashing)
                {
                    StartCoroutine(CheckDash());
                }
            } 
        }
    }

    private IEnumerator CheckDash()
    {
        Vector3 forceDirection = directionDash * dashingPowerToPlayer;
        rigidbodyPlayer.AddForce(forceDirection, ForceMode.Impulse);

        trailRenderer.emitting = true;
        yield return delayDashTime;
        isDashing = false;
        trailRenderer.emitting = false;
    }
}
