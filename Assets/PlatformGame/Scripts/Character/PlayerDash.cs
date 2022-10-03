using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    private PlayerPowerUps playerPowerUps;

    [Header("General")]
    [SerializeField] private TrailRenderer trailRenderer;

    [Header("Checker")]
    [SerializeField] private bool isDashing;

    [Header("Values")]
    [Range(0, 5)]
    [SerializeField] private float dashingPowerToPlayer;
    [SerializeField] private Vector3 directionDash;

    private Rigidbody rigidbodyPlayer;
    private WaitForSeconds delayDashTime = new WaitForSeconds(1f);

    private void Awake()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
        playerPowerUps = GetComponent<PlayerPowerUps>();
    }

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
                    StartCoroutine(CheckDash());
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
