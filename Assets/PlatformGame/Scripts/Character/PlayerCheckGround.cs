using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckGround : MonoBehaviour
{
    private bool _isGround;
    public bool isGround //ENCAPSULATION
    {
        get { return _isGround; }
        set { _isGround = value; }
    }


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
    
}
