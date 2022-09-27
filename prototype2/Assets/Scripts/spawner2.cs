using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    spawner spawnerScript;
    public GameObject objSpawner;

    public GameObject enemyToSpawn2;
    public bool enemy2Dead;

    // Start is called before the first frame update
    void Start()
    {
        spawnerScript = objSpawner.GetComponent<spawner>();

        SpawnEnemy2();
        enemy2Dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy2Dead == true) {
            if (spawnerScript.totalEnemies <= 9) {
                SpawnEnemy2();
                spawnerScript.totalEnemies++;
                Debug.Log("enemies" + spawnerScript.totalEnemies);  
            }
            // else if (spawnerScript.totalEnemies >= 10) {
            //     Debug.Log("you win!!");
            // }
        }
    }

    Vector2 GetSpawnPoint2() {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    public void SpawnEnemy2() {
        Instantiate(enemyToSpawn2, GetSpawnPoint2(), Quaternion.identity);
        enemy2Dead = false;
    }
}
