using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4PlayerMove : MonoBehaviour{

    private Rigidbody2D _ball;

    void Start() {
        _ball = GetComponent<Rigidbody2D>();
    }
    // Only move the player along the x-axis
    void Update() {
        _ball.velocity = new Vector2(Input.acceleration.x * 20, 0);
    }
}
