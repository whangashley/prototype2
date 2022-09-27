using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAim : MonoBehaviour
{
    public bool enemyOverlap;
    public bool enemyKill;

    public bool enemy2Overlap;
    public bool enemy2Kill;

    public bool enemy3Overlap;
    public bool enemy3Kill;

    spawner spawnerScript;
    public GameObject objSpawner;
    // SpriteRenderer enemyRenderer;

    spawner2 spawner2Script;
    public GameObject objSpawner2;
    // SpriteRenderer enemyRenderer2;

    spawner3 spawner3Script;
    public GameObject objSpawner3;
    // SpriteRenderer enemyRenderer3;
    
    public GameObject matzoBall;

    // Start is called before the first frame update
    void Start()
    {
       enemyOverlap = false; 
       enemyKill = false;

       enemy2Overlap = false;
       enemy2Kill = false;

       enemy3Overlap = false;
       enemy3Kill = false;

    //    objSpawner.GetComponent<SpriteRenderer>();
    //    objSpawner2.GetComponent<SpriteRenderer>();
    //    objSpawner3.GetComponent<SpriteRenderer>();
       spawnerScript = objSpawner.GetComponent<spawner>();
       spawner2Script = objSpawner2.GetComponent<spawner2>();
       spawner3Script = objSpawner3.GetComponent<spawner3>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            if (enemyOverlap == true) {
               Debug.Log("pressed"); 
                // enemyKill = true;
                SpawnMatzo();
                StartCoroutine(enemy1DeadCountDown());
            }
            if (enemy2Overlap == true) {
                Debug.Log("pressed 2");
                // enemy2Kill = true;
                SpawnMatzo();
                StartCoroutine(enemy2DeadCountDown());
            }
            if (enemy3Overlap == true) {
                Debug.Log("pressed3");
                // enemy3Kill = true;
                SpawnMatzo();
                StartCoroutine(enemy3DeadCountDown());
            }
        }
    }

    public void SpawnMatzo() {
        Instantiate(matzoBall, transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "enemy") {
            enemyOverlap = true;
        }
            else {
                enemyOverlap = false;
            }
        if (collision.gameObject.tag == "enemy2") {
            enemy2Overlap = true;
        }
            else {
                enemy2Overlap = false;
            }
        if (collision.gameObject.tag == "enemy3") {
            enemy3Overlap = true;
        }
            else {
                enemy3Overlap = false;
            }
    }

    private IEnumerator enemy1DeadCountDown() {
        yield return new WaitForSeconds(5f);
        spawnerScript.enemy1Dead = true;
    }

    private IEnumerator enemy2DeadCountDown() {
        yield return new WaitForSeconds(5f);
        spawner2Script.enemy2Dead = true;
    }

    private IEnumerator enemy3DeadCountDown() {
        yield return new WaitForSeconds(5f);
        spawner3Script.enemy3Dead = true;
    }


    // void OnTriggerEnter2D(Collider2D collision) {
    //     if (collision.gameObject.tag == "enemy") {
    //         enemyOverlap = true;
    //         if (enemyKill == true) {
    //             Destroy(collision.gameObject);
    //             enemyKill = false;
    //         }         
    //     }
    //     else {
    //         enemyOverlap = false;
    //         enemyKill = false;
    //     }

    //     if (collision.gameObject.tag == "enemy2") {
    //         enemy2Overlap = true;    
    //         if (enemy2Kill == true) {
    //             Destroy(collision.gameObject);
    //             enemy2Kill = false;
    //         }                
    //     }
    //     else {
    //         enemy2Overlap = false;
    //         enemy2Kill = false;
    //     }

    //     if (collision.gameObject.tag == "enemy3") {
    //         enemy3Overlap = true;   
    //         if (enemy3Kill == true) {
    //             Destroy(collision.gameObject);
    //             enemy3Kill = false;
    //         }                 
    //     }
    //     else {
    //         enemy3Overlap = false;
    //         enemy3Kill = false;
    //     }
    // }

    // void OnTriggerExit2D(Collider2D collision) {
    //     if (collision.gameObject.tag == "enemy" && enemyKill == true) {
    //         Destroy(collision.gameObject);
    //         enemyKill = false;
    //     }
    //     if (collision.gameObject.tag == "enemy2" && enemy2Kill == true) {
    //         Destroy(collision.gameObject);
    //         enemy2Kill = false;
    //     }
    //     if (collision.gameObject.tag == "enemy3" && enemy3Kill == true) {
    //         Destroy(collision.gameObject);
    //         enemy3Kill = false;
    //     }
    // }
}
