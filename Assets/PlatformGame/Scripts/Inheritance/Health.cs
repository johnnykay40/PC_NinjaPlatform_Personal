using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour //ABSTRACT
{
    public int healthValue;    

    public virtual void HealthController(int damage){ }

}
