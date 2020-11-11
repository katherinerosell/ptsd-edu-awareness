using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * This script is attached to the FinishLine gameObject in Level 14.
 * If the player hits this box, then they continue to Level16!
 * */

public class FinishLineScript : MonoBehaviour {

    private BoxCollider2D finishLineBox;

    private void Start() {
        finishLineBox = GetComponent<BoxCollider2D>();
    }

    // if the player hits the finish line, move on to level 16
    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "Player") SceneManager.LoadScene("Level16");
    }

}
