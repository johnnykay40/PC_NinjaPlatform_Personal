using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    private PlayerPowerUps playerPowerUps;
    private TrailRenderer trailRenderer;

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
        trailRenderer = GetComponent<TrailRenderer>();
        rigidbodyPlayer = GetComponent<Rigidbody>();
        playerPowerUps = GetComponent<PlayerPowerUps>();
    }

    internal void CallDash()
    {
        isDashing = true;

        if (isDashing)
            StartCoroutine(CheckDash());
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
