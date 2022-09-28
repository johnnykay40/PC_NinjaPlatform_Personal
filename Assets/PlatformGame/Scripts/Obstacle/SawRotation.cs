using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotation : MonoBehaviour
{
    [SerializeField] private float trapSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up, trapSpeed * Time.deltaTime);
    }
}
