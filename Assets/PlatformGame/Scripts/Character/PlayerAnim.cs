using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    internal Animator playerAnim;

    public string nameAnimRunning;
    public string nameAnimSwimming;
    public string nameAnimJump;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        PlayerVerifyDirection.OnAnimRunning += AnimRunning;
        PlayerVerifyDirection.OnAnimSwimming += AnimSwimming;
        PlayerJump.OnAnimJump += AnimJump;
    }

    internal void AnimRunning(bool value) => playerAnim.SetBool(nameAnimRunning, value);
    internal void AnimSwimming(bool value) => playerAnim.SetBool(nameAnimSwimming, value);
    internal void AnimJump() => playerAnim.SetTrigger(nameAnimJump);

    private void OnDisable()
    {
        PlayerVerifyDirection.OnAnimRunning -= AnimRunning;
        PlayerVerifyDirection.OnAnimSwimming -= AnimSwimming;
        PlayerJump.OnAnimJump -= AnimJump;
    }
}


