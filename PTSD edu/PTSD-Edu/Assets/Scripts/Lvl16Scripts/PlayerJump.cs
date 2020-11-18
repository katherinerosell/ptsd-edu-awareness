using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    private bool grounded;
    private Rigidbody2D playerRB;

    private void Start() {
        playerRB = GetComponent<Rigidbody2D>();
        grounded = true;
    }

    public void Jump() {
        if(grounded) playerRB.AddForce(new Vector2(0f, 180f), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "ground") grounded = true;
        Debug.Log("Is Player Grounded?  " + grounded);
    }

    private void OnCollisionExit2D(Collision2D collision) {
        grounded = false;
        Debug.Log("Is Player Grounded?  " + grounded);
    }

}
