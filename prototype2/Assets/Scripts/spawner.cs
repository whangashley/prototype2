using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public int totalEnemies;

    public bool enemy1Dead;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnEnemy", 2, 1);
        SpawnEnemy1();
        enemy1Dead = false;
        totalEnemies = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // CountD -= Time.deltaTime;
        if (enemy1Dead == true) {
            if (totalEnemies <= 9) {
                SpawnEnemy1();
                totalEnemies++;
                Debug.Log("enemies" + totalEnemies);
            }
            // else if (totalEnemies >= 10) {
            //     Debug.Log("you win!");
            // }
        } 
    }

    Vector2 GetSpawnPoint1() {
        float x = Random.Range(-5f, -3f);
        float y = Random.Range(1f, 4f);

        return new Vector2(x, y);
    }

    public void SpawnEnemy1() {
        Instantiate(enemyToSpawn, GetSpawnPoint1(), Quaternion.identity);
        enemy1Dead = false;
    }
}
