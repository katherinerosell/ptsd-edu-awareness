using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script is attached to the WordText prefab. Even though the 
 * player is colliding with the Text object since the Box Collider2D
 * is around it, it is better to handle collisions in the parent object.
 * The player script, IAmPlayer, handles when they collide with the 
 * WordText game object. 
 * ERR: Collisions on main game object no longer detect??????
 * Re:ERR: This script destroyed ITSELF - it destroys the script, not WordText
 * WordText uses a isTrigger Box Collider, so the player is unable to detect it.
 * Author: Katherine Rosell
 * Date: August 2020
 * */

public class WordTextCollisions : MonoBehaviour {
    private GameObject _player;
    private static IAmPlayer amPlayer;
    private void Start() {
        _player = GameObject.Find("Player");
        amPlayer = _player.GetComponent<IAmPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "KillWall") Destroy(gameObject);
        if (c.gameObject.tag == "Player") {
            amPlayer.playerHit();
            Destroy(gameObject);               
        } 
    }

    // If isTrigger is disabled, still account for collisions
    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "KillWall") Destroy(gameObject);
        if (c.gameObject.tag == "Player") {
            amPlayer.playerHit();
            Destroy(gameObject);               
        } 
    }

}
