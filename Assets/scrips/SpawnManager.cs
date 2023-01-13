using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spwanRangeX = 20;
    private float spwanPosZ = 20;
    private float startdelay=2;
    private float spawninterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomanimal",startdelay,spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void spawnRandomanimal()
    {
        Vector3 spawnPos =new Vector3(Random.Range(-spwanRangeX, spwanRangeX),0,spwanPosZ);
            int animalInde = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalInde], spawnPos, animalPrefabs[animalInde].transform.rotation);
    }
}
