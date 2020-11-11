using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl14PlayerCollision : MonoBehaviour {

    private SpriteRenderer sprite; // the player's sprite renderer
    private int hits; // on first, on second hit... color is different

    [SerializeField]
    Color medRed;
    [SerializeField]
    Color deepRed;
    [SerializeField]
    Color ogWhite;

    private void Start() {
        hits = 0;
        sprite = GetComponent<SpriteRenderer>();
    }
    // Bug: this script does not seem to be detecting collisions with the WordPrefab
    // 'on trigger enter' or 'on collision enter' ?
    private void OnTriggerEnter2D(Collider2D c) {
        Debug.Log("Hit Something - TRIGGER");
        if (c.gameObject.tag == "Enemy") {
            hits++;
            ManageColor();        
        }
        if (c.gameObject.tag == "Breeze") { // decrease the htis, and reduce redness in player
            hits--;
            ManageColor();
        }
    }

    // to allow the trigger collision to use the same code without having to repeat within
    // this separate function assigns the color in accordance with the hit total
    private void ManageColor() {
        if (hits < 0) hits = 0;
        if (hits >= 3) SceneManager.LoadScene("Level14"); //restart the level if 3 or more hits taken
        switch (hits) {
            case 0:
                sprite.color = ogWhite;
                break;
            case 1:
                sprite.color = medRed;
                break;
            case 2:
                sprite.color = deepRed;
                break;
        }
    }

}
