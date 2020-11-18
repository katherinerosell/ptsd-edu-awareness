using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Used in Level 7
 * Instantiate enemies outside the field of view and make them
 * track and follow the player's position.
 * This script will be attached to the WordText prefab once it is
 * instantiated
 * 
 */
public class TrackingEnemy : MonoBehaviour {

    private Rigidbody2D _player;
    private Vector2 playerLoc;

    private Rigidbody2D wordRB;
    private Vector2 wordLoc;

    private float speed;
    private bool inZone; // if this word is in the circle collider zone
    private int _pillarInt;

    private void Start() {
        _pillarInt = 2; // pillarA = 0, pillarB = 1
        inZone = false;
        speed = 6f;
        _player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        wordRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        wordLoc = new Vector2(wordRB.position.x, wordRB.position.y);
        playerLoc = new Vector2(_player.position.x, _player.position.y);
        wordRB.position = Vector2.MoveTowards(wordLoc, playerLoc, speed * Time.deltaTime);
    }

    public void setSpeed(int newSpeed) {
        speed = newSpeed;
    }

    // when WordText collides with pillar's circle trigger collider
    private void OnTriggerEnter2D(Collider2D c) {        
        if (c.gameObject.tag == "pillar") { // circle collider is the pillar
            if (c.gameObject.name == "PillarA") { _pillarInt = 0; }
            else if(c.gameObject.name == "PillarB") { _pillarInt = 1; } // pillarB = 1
            inZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D c) {
        _pillarInt = 2;
        inZone = false;
    }

    public bool WithinZone() {
        return inZone;
    }

    public int getPillarInt() {
        return _pillarInt;
    }


}
