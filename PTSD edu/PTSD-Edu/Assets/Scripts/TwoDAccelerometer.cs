using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDAccelerometer : MonoBehaviour {

    private Rigidbody2D _ball;

    private void Start() {
        _ball = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        _ball.velocity = new Vector2(Input.acceleration.x * 20, (Input.acceleration.y + 0.3f) * 22);
    }

}
