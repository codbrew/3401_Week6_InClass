using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnXPosition = 12;
    public GameObject skyscrapperInstance;
    public float spawnNewTriggerXPos = 0;

    Transform lastSpawnedPipe;
    // Start is called before the first frame update
    void Start()
    {
        //instantiate skyscrapper at spawnpoint with set transform and rotation
        //Instantiate(skyscrapperInstance, new Vector3(spawnXPosition, 0, 0), Quaternion.identity);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawnedPipe == null)
        {
            //instantiate skyscrapper at spawnpoint with set transform and rotation
            lastSpawnedPipe = Instantiate (skyscrapperInstance, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
        }
        else
        {
            if(lastSpawnedPipe.position.x < spawnNewTriggerXPos)
            {
                lastSpawnedPipe = Instantiate(skyscrapperInstance, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
            }
        }
    }
}
