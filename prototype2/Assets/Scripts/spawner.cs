using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public int totalEnemies;

    public bool enemy1Dead;
    public bool enemy2Dead;
    public bool enemy3Dead;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnEnemy", 2, 1);
        SpawnEnemy1();
        SpawnEnemy2();
        SpawnEnemy3();

        enemy1Dead = false;
        enemy2Dead = false;
        enemy3Dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        // CountD -= Time.deltaTime;
        if (enemy1Dead == true) {
            SpawnEnemy1();
            totalEnemies++;
        } 

        if (enemy2Dead == true) {
            SpawnEnemy2();
            totalEnemies++;
        }
        if (enemy3Dead == true) {
            SpawnEnemy3();
            totalEnemies++;
        }
    }

    Vector2 GetSpawnPoint1() {
        float x = Random.Range(-5f, -3f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    Vector2 GetSpawnPoint2() {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    Vector2 GetSpawnPoint3() {
        float x = Random.Range(3f, 5f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    public void SpawnEnemy1() {
        Instantiate(enemyToSpawn, GetSpawnPoint1(), Quaternion.identity);
        enemy1Dead = false;
    }
    public void SpawnEnemy2() {
        Instantiate(enemyToSpawn, GetSpawnPoint2(), Quaternion.identity);
        enemy2Dead = false;
    }
    public void SpawnEnemy3() {
        Instantiate(enemyToSpawn, GetSpawnPoint3(), Quaternion.identity);
        enemy3Dead = false;
    }
}
