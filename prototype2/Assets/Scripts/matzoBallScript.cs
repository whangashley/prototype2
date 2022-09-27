using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matzoBallScript : MonoBehaviour
{
    public bool matzoHit;
    public bool alphaZero;

    public Animator matzoBallAnimator;

    public float killTime;

    public float fadeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        matzoHit = false;
        alphaZero = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "enemy") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetTrigger("matzoFade");
            matzoHit = true;
            StartCoroutine(killCountDown());
        }
        if (collision.gameObject.tag == "enemy2") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetTrigger("matzoFade");
            matzoHit = true;
            StartCoroutine(killCountDown());

        }
        if (collision.gameObject.tag == "enemy3") {
            Destroy(collision.gameObject);
            matzoBallAnimator.SetTrigger("matzoFade");
            matzoHit = true;
            StartCoroutine(killCountDown());

        }
        else {
            StartCoroutine(FadeOutMaterial(1f));
        }
    }

    void DestroyGameObject() {
       Destroy(gameObject);
    }

    private IEnumerator killCountDown() {
        yield return new WaitForSeconds(killTime);
        Destroy(gameObject);
    }

    IEnumerator FadeOutMaterial(float fadeSpeed) {
        Renderer rend = GetComponent<Renderer>();
        Color matColor = rend.material.color;
        float alphaValue = rend.material.color.a;

        while (rend.material.color.a > 0f)
        {
            alphaValue -= Time.deltaTime / fadeSpeed;
            rend.material.color = new Color(matColor.r, matColor.g, matColor.b, alphaValue);
            yield return null;
        }
        rend.material.color = new Color(matColor.r, matColor.g, matColor.b, 0f);
        StartCoroutine(killCountDown());
    }
}
