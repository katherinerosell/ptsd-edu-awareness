using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This script is in level 4. If 3 words are able to touch
 * the ground, restart the level!
 * */
public class GroundScript : MonoBehaviour {

    private BoxCollider2D groundBox;
    private int groundHits;

    private void Start() {
        groundHits = 0;
        groundBox = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) { // using isTrigger since WordText uses it
        groundHits++;
        Debug.Log("Ground Hits = " + groundHits);
        if (groundHits >= 3) SceneManager.LoadScene("Level4"); // load THIS - Level4 - scene
    }

}
