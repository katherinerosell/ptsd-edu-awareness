using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * Used in Level14, Level16. When the player is hit
 * by the word in this case, their color becomes more red.
 * And their movement becomes a bit more unstable - they move
 * much faster and it's a bit harder to control. The breeze object
 * cools them down, reducing redness/aggitation, normalizing their speed. 
 * Hit 3 times by the word, restart the current level. 
 * */
public class Lvl14PlayerCollision : MonoBehaviour {

    private SpriteRenderer sprite; // the player's sprite renderer
    private int hits; // on first, on second hit... color is different
    private TwoDAccelerometer accelScript; // the accelerometer script
    private Scene currentSene; // the current scene player is on

    [SerializeField]
    Color medRed;
    [SerializeField]
    Color deepRed;
    [SerializeField]
    Color ogWhite;

    private void Start() {
        accelScript = GetComponent<TwoDAccelerometer>();
        hits = 0;
        sprite = GetComponent<SpriteRenderer>();
        currentSene = SceneManager.GetActiveScene();
    }
    // Bug: this script does not seem to be detecting collisions with the WordPrefab
    // 'on trigger enter' or 'on collision enter' ?
    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Enemy") {
            hits++;
            ManageColor();        
        }
        if (c.gameObject.tag == "breeze") { // decrease the htis, and reduce redness in player
            Destroy(c.gameObject);
            hits--;
            ManageColor();
        }
    }

    // to allow the trigger collision to use the same code without having to repeat within
    // this separate function assigns the color in accordance with the hit total
    private void ManageColor() {
        Debug.Log("Hits:   " + hits);
        if (hits < 0) hits = 0;
        if (hits >= 3) SceneManager.LoadScene(currentSene.name); //restart the level if 3 or more hits taken
        switch (hits) {
            case 0:
                sprite.color = ogWhite;
                accelScript.setXMult(20);
                accelScript.setYMult(22);
                break;
            case 1:
                sprite.color = medRed;
                accelScript.setXMult(40);
                accelScript.setYMult(46);
                break;
            case 2:
                sprite.color = deepRed;
                accelScript.setXMult(70);
                accelScript.setYMult(78);
                break;
        }
    }

}
