using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl16FollowKillWall : MonoBehaviour {
    public Transform playerTransform;

    private void FixedUpdate() {
        transform.position = new Vector2(transform.position.x - 30, playerTransform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "breeze") Destroy(c.gameObject);
    }

}
