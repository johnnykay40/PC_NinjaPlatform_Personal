using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public static PlayerMovement Instance;
    
    [Header("Parameter's")]
    [Range(0,50)]
    [SerializeField] private float playerSpeed;
    
    internal Vector3 displacement;
    private float horizontalMovement;
    
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
        PlayerMove();        
    }

    private void PlayerMove()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        displacement.Set(0f, 0f, horizontalMovement);

        displacement = displacement.normalized * playerSpeed * Time.deltaTime;
    }

   
}
