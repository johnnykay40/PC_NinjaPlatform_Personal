using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrapRotation : MonoBehaviour
{
    [SerializeField] private float trapSpeed;

        private void Update()
    {
        transform.Rotate(Vector3.back, trapSpeed * Time.deltaTime);
    }

}
