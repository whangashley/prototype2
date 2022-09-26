using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matzoBallScript : MonoBehaviour
{
    public bool matzoHit;
    public bool alphaZero;

    public Animator matzoBallAnimator;
    // Start is called before the first frame update
    void Start()
    {
        matzoHit = false;
        alphaZero = false;

        matzoBallAnimator.SetBool("enemyHit", false);
        matzoBallAnimator.SetBool("matzoDie", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (matzoHit == true) {
            //fade alpha
            // matzoBallAnimator.SetBool("enemyHit", true);
            matzoBallAnimator.SetBool("matzoDie", true);
            matzoHit = false;
        }

        //if alpha becomes 0
        //alphaZero is true
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "enemy") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetBool("enemyHit", true);
            // matzoBallAnimator.SetBool("matzoDie", true);
            matzoHit = true;
        }
        if (collision.gameObject.tag == "enemy2") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetBool("enemyHit", true);
            // matzoBallAnimator.SetBool("matzoDie", true);
            matzoHit = true;
        }
        if (collision.gameObject.tag == "enemy3") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetBool("enemyHit", true);
            // matzoBallAnimator.SetBool("matzoDie", true);
            matzoHit = true;
        }
    }

    private void OnBecameInvisible() {
       Destroy(gameObject);
    }
}
