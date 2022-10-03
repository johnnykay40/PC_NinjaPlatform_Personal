using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    internal Animator playerAnim;

    [SerializeField] private string nameAnimRunning;
    [SerializeField] private string nameAnimSwimming;
    [SerializeField] private string nameAnimJump;

    private void Awake() => playerAnim = GetComponent<Animator>();

    private void OnEnable()
    {
        PlayerVerifyDirection.OnAnimRunning += AnimRunning;
        PlayerVerifyDirection.OnAnimSwimming += AnimSwimming;
        PlayerJump.OnAnimJump += AnimJump;
    }

    private void AnimRunning(bool value) => playerAnim.SetBool(nameAnimRunning, value);
    private void AnimSwimming(bool value) => playerAnim.SetBool(nameAnimSwimming, value);
    private void AnimJump() => playerAnim.SetTrigger(nameAnimJump);

    private void OnDisable()
    {
        PlayerVerifyDirection.OnAnimRunning -= AnimRunning;
        PlayerVerifyDirection.OnAnimSwimming -= AnimSwimming;
        PlayerJump.OnAnimJump -= AnimJump;
    }
}