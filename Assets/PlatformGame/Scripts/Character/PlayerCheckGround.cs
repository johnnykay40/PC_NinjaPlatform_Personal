using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckGround : MonoBehaviour
{
    [SerializeField] internal bool isGround;

    [SerializeField] private Transform rayCastGround;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask layerMask;
    
    private void FixedUpdate()
    {
        CheckGround();
    }
    private void CheckGround()
    {
        isGround = Physics.CheckSphere(rayCastGround.position, radius, (int)layerMask);
    }

    private void OnDrawGizmos()
    {
        if (isGround)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        Gizmos.DrawSphere(transform.position, radius);

    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Ground"))
    //    {
    //        isGround = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //        isGround = false;
    //}
}
