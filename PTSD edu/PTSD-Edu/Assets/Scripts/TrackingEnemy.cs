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

    private void Start() {
        speed = 5f;
        _player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        wordRB = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        wordLoc = new Vector2(wordRB.position.x, wordRB.position.y);
        playerLoc = new Vector2(_player.position.x, _player.position.y);
        // slope formula, y = mx+b, y2-y1/x2-x1, playerLoc-wordLoc
        // float x = playerLoc.x - wordLoc.x;
        // float y = playerLoc.y - wordLoc.y;
        wordRB.position = Vector2.MoveTowards(wordLoc, playerLoc, speed * Time.deltaTime);
    }

    public void setSpeed(int newSpeed) {
        speed = newSpeed;
    }


}
