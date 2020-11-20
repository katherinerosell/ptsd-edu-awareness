using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl10PlayerMove : MonoBehaviour {
    private Rigidbody2D _ball;

    void Start() {
        Debug.Log("Lvl10PlayerMove - I Am Alive!");
        _ball = GetComponent<Rigidbody2D>();
    }
    // Only move the player along the x-axis
    void FixedUpdate() {
        _ball.AddForce(new Vector2(Input.acceleration.x* 190, _ball.velocity.y + 0));
    }

}

