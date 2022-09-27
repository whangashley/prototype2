using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner3 : MonoBehaviour
{
    spawner spawnerScript;
    public GameObject objSpawner;

    public GameObject enemyToSpawn3;
    public bool enemy3Dead;

    // Start is called before the first frame update
    void Start()
    {
        spawnerScript = objSpawner.GetComponent<spawner>();

        SpawnEnemy3();
        enemy3Dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy3Dead == true) {
            if (spawnerScript.totalEnemies <= 9) {
                SpawnEnemy3();
                spawnerScript.totalEnemies++;
                Debug.Log("enemies" + spawnerScript.totalEnemies);  
            }
            // else if (spawnerScript.totalEnemies >= 10) {
            //     Debug.Log("you win!!!");
            // }
        }
    }

    Vector2 GetSpawnPoint3() {
        float x = Random.Range(3f, 5f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    public void SpawnEnemy3() {
        Instantiate(enemyToSpawn3, GetSpawnPoint3(), Quaternion.identity);
        enemy3Dead = false;
    }
}
