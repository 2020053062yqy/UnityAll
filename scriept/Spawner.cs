using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] enemies;
    void Start()
    {
        InvokeRepeating ("SpawnEnemy",2,1);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        int index = Random .Range (0,1);
        Instantiate (enemies[index], transform.position, transform .localRotation );
    }
    void Update()
    {
        
    }
}
