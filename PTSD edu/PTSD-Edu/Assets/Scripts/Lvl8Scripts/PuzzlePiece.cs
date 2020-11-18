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
    private static int pieces;

    private void Start() {
        pieces = 4; // there are 4 pieces of the puzzle
        poly2D = GetComponent<PolygonCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "puzzle") {            
            Destroy(gameObject);
            Destroy(c.gameObject);
            pieces --; // each puzzle piece has this script, so just minus one per collision
            // since they're colliding with themselves
            Debug.Log("Puzzle piece hit!! Pieces Left:   " + pieces);
        }
        if (pieces == 0) {
            Debug.Log("Loading Level 10...");
            SceneManager.LoadScene("Level10");
        }
    }

}
