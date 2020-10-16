using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* Script used in Level 4 for creating the words that fall down with the rain.
 * Responsible for keeping track of time, instantiating the word and moving it.
 * Also used to move on to the next level.
 *   Author: Katherine Rosell
 *   Date: September 2020
 *   */
public class Lvl4CreateWord : MonoBehaviour {
    public Rigidbody2D wordRB;
    private static float myTimer = 0;
    private float fallVelocity;
    private float min;
    private float max;

    void Start() {
        fallVelocity = -10f;
        min = 2f; max = 5f;
        wordRB = wordRB.GetComponent<Rigidbody2D>();
        myTimer = 0f;
        Invoke("InstantiateFallingWord", 1.5f);
        InvokeRepeating("FallRate", 2, 10);
    }

    void Update() {
        myTimer = myTimer + Time.deltaTime;
        // after 2 minutes, move onto the next level
        if ((int)myTimer >= 120 && (int)myTimer <= 121) {
            SceneManager.LoadScene("Level7");
        } else { }
    }

    private void InstantiateFallingWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-56f, 60f);
        wordPrefab.position = new Vector3(Xpos, 35, 15);
        wordPrefab.velocity = new Vector2(0f, fallVelocity); // move downwards
        Invoke("InstantiateFallingWord", Random.Range(min, max));
    }

    private void FallRate() {
        if (min <= 0.4f) {

        }
        else {
            min -= 0.2f;
            max -= 0.5f;
            fallVelocity -= 1.5f;
            InstantiateFallingWord();
        }        
    }

}
