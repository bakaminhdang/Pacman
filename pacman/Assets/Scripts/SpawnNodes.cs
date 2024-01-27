using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNodes : MonoBehaviour
{
    int numToSpawn = 28;
    public float currentSpawnoffset;
    public float spawnoffset = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
      
       /* if(gameObject.name == "Node")
        {
            currentSpawnoffset = spawnoffset;
            for(int i = 0; i < numToSpawn; i++)
            {
                //tao 1 cai node moi
                GameObject clone = Instantiate(gameObject,new Vector3(transform.position.x , transform.position.y + currentSpawnoffset, 0),Quaternion.identity);
                currentSpawnoffset += spawnoffset;
            }
           
        }*/ // code sinh ra cham pallet

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
