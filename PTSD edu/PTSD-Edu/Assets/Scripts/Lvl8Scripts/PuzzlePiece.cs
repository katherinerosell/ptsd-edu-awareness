using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * This script is attached to all the puzzle pieces.
 * When 2 pieces collide, themselves plus the piece
 * they collided with will be destroyed. 
 * When the four pieces have been destroyed, 
 * move on to level 10!
 * Date: 10/18/2020
 * */
public class PuzzlePiece : MonoBehaviour {

    private PolygonCollider2D poly2D;
    private int pieces;

    private void Start() {
        pieces = 4; // there are 4 pieces of the puzzle
        poly2D = GetComponent<PolygonCollider2D>();
    }

    private void Update() {
        if (pieces == 0) {
            SceneManager.LoadScene("Level10");
        }
    }

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "puzzle") {
            Debug.Log("Puzzle piece hit!!");
            Destroy(gameObject);
            Destroy(c.gameObject);
            pieces =- 2;
        }
    }

}
