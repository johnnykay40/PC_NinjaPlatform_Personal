using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwim : MonoBehaviour
{
    public bool isUnderwater = false;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isUnderwater = true;            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isUnderwater = false;            
        }
    }
    void Update()
    {
        if (isUnderwater == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                PlayerManager.playerManager.statePlayer = PlayerManager.StatePlayer.swim;
                Debug.Log("swimming up");                
            }
        }
    }
}
