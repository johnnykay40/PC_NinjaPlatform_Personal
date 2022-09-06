using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFishManager : MonoBehaviour
{
    [SerializeField] private GameObject[] fishPrefabs;    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {            
            int fishIndex = Random.Range(0, fishPrefabs.Length);

            Vector3 randomSpawnPosition = new Vector3(-93, Random.Range(-4, -12), Random.Range(66, 0));

            Instantiate(fishPrefabs[fishIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}
