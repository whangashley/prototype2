using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float scanRadius = 0.5f;
    public LayerMask filterMask;
    private spawner SP; 
    private Collider2D checkCollider;

    // spawner spawnerScript;
    // public GameObject objSpawner;

    void Start() 
    {
        SP = FindObjectOfType<spawner>();
        // spawnerScript = objSpawner.GetComponent<spawner>();        
        
        // objSpawner = GameObject.FindWithTag("spawner");

        // spawnerScript = objSpawner.GetComponent<spawner>();
        
        // objSpawner.GetComponent<spawnerScript>();


    }
    
    void Update()
    {
        // checkCollider = Physics2D.OverlapCircle(transform.position, scanRadius, filterMask);
        // if (checkCollider != null && checkCollider.transform != transform) {
        //     Debug.Log("overlap");
        //     Destroy(checkCollider.gameObject);
        //     // spawner.CountD = 0; 
        //     SP.CountD = 0;
        //     // objSpawner.GetComponent<spawner>.CountD = 0;
        // }
    }
    
    // protected void OnDrawGizmos() {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position, scanRadius);
    // } 

    // void OnTriggerEnter2D(Collider2D collision) {
    //     if (collision.gameObject.tag == "enemy") {
    //         Destroy(gameObject);
    //     }
    // }

}
