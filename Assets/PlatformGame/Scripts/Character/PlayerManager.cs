using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerJump))]
[RequireComponent(typeof(PlayerRotation))]
[RequireComponent(typeof(PlayerAnim))]
[RequireComponent(typeof(PlayerVerifyDirection))]
[RequireComponent(typeof(PlayerPowerUps))]
[RequireComponent(typeof(PlayerDash))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Animator))]

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager playerManager;
    public enum StatePlayer { idle, swim, running, shooting, hang, dash, jump}
    public StatePlayer statePlayer;

    private void Awake() => playerManager = this;

}
