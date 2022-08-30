using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    internal Animator playerAnim;

    public string nameAnimRunning;
    public string nameAnimJump;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        PlayerMovement.OnAnimRunning += AnimRunning;
        PlayerJump.OnAnimJump += AnimJump;
    }

    internal void AnimRunning(bool value) => playerAnim.SetBool(nameAnimRunning, value);
    internal void AnimJump() => playerAnim.SetTrigger(nameAnimJump);

    private void OnDisable()
    {
        PlayerMovement.OnAnimRunning -= AnimRunning;
        PlayerJump.OnAnimJump -= AnimJump;
    }
}


