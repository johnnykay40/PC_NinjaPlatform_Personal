using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int healthPlayer;

    private void HealthPlayer(int damage)
    {
        healthPlayer -= damage;
    }
}
