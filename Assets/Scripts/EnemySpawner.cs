using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyToSpawn;
    public bool canSpawn = true;
    public float enemySpawnTime = 1.0f;
    public float maxX = 28.0f;
    public float startingY = 20.0f;
    float randomX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnEnemyTimer()
    {
        while(canSpawn == true){
        spawnEnemy();
        yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void spawnEnemy()
    {
        randomX = Random.Range(-maxX, maxX);

        Instantiate (enemyToSpawn, new Vector3(randomX, startingY, 0), Quaternion.identity);
    }
}
