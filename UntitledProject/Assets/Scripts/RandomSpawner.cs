using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        //Lebosada, replace is "IF" Statememt to which everytime the player press start, the object falls.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-12, 13), 5, Random.Range(-3, -3));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}