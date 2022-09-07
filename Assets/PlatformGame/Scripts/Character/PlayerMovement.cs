using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public static PlayerMovement Instance;
    
    [Header("Parameter's")]
    [Range(0,50)]
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private TrailRenderer trailRenderer;
    
    internal Vector3 displacement;
    private float horizontalMovement;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;

    
    //With Singleton
    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void Update()
    {
        if (isDashing)
        {
            return;
        }

        PlayerMove();

        if (Input.GetKeyDown(KeyCode.E) && canDash)
        {
            StartCoroutine(Dash());
        }
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
    }

    private void PlayerMove()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        displacement.Set(0f, 0f, horizontalMovement);

        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
    }

   private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rigidBody.gravityScale;
        rigidBody.gravityScale = 0f;
        rigidBody.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        trailRenderer.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        trailRenderer.emitting = false;
        rigidBody.gravityScale = originalGravity;
        isDashing = false;
        canDash = true;

    }


}
