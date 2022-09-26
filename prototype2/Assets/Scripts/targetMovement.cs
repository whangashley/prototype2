using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{
    public float accelTime;
    // public float maxSpeed = 5f;
    private Vector2 movement;
    public float timeLeft;

    public Rigidbody2D rb;
    // public float speed = 1;

    public float countDownTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        rb.isKinematic = true;
        
        if (timeLeft <= 0) {
            rb.isKinematic = false;
            movement = new Vector2(Random.Range(-6.6f, 6.6f), Random.Range(0f, 5f));
            movement = movement.normalized * 2;
            rb.AddForce(movement, ForceMode2D.Impulse);
            timeLeft += accelTime;
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "barrier") {
            rb.isKinematic = false;
            rb.velocity = rb.velocity * -0.9f;
        }
    }

    private IEnumerator countDownCo(Rigidbody2D rb) {
        yield return new WaitForSeconds(countDownTime);
        rb.isKinematic = true;
    }
}
