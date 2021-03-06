﻿using System.Collections;
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
        fallVelocity = -9f;
        min = 3f; max = 5f;
        wordRB = wordRB.GetComponent<Rigidbody2D>();
        myTimer = 0f;
        Invoke("InstantiateFallingWord", 2f);
        //InvokeRepeating("FallRate", 2, 10);
    }

    void Update() {
        myTimer = myTimer + Time.deltaTime;
        // after 1.5 minutes, move onto the next level
        if ((int)myTimer >= 90 && (int)myTimer <= 91) {
            SceneManager.LoadScene("Level7");
        } else { }
    }

    private void InstantiateFallingWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-56f, 60f);
        wordPrefab.position = new Vector3(Xpos, 35, 15);
        wordPrefab.velocity = new Vector2(0f, fallVelocity); // move downwards
        float repeatNum = Random.Range(min, max);
        Invoke("InstantiateFallingWord", repeatNum);
    }
    // shrink spawn time so word spawns more frequently - but it
    // makes gameplay TOO difficult
    private void FallRate() {
        if (min <= 3.0f) { // repeats about 10 times

        }
        else {
            min -= 0.1f;
            max -= 0.4f;
            // fallVelocity -= 0.1f;
            InstantiateFallingWord();
        }        
    }

}
