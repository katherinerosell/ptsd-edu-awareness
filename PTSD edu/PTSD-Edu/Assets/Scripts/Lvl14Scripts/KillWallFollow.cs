using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Used in Level14, Level16. Script is attached to a gameobject with a 2D Box Collider, 
 * tagged as "KillWall" . This object would be following the player from a distance back
 * */
public class KillWallFollow : MonoBehaviour {

    public Transform playerTransform;

    private void FixedUpdate() {
        transform.position = new Vector2(transform.position.x, playerTransform.position.y - 30);
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "breeze") Destroy(c.gameObject);
    }

}
