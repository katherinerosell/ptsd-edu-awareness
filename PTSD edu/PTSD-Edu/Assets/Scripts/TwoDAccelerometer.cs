using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDAccelerometer : MonoBehaviour {

    private Rigidbody2D _ball;
    private int xMult; // integer to multiply to the x input value
    private int yMult; // integer to multiply to the y input value

    private void Start() {
        xMult = 20;
        yMult = 22;
        _ball = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        _ball.velocity = new Vector2(Input.acceleration.x * xMult, (Input.acceleration.y) * (yMult + 0.8f));
    }

    public void setXMult(int tempX) {
        xMult = tempX;
    }

    public int getXMult() {
        return xMult;
    }

    public void setYMult(int tempY) {
        yMult = tempY;
    }

    public int getYMult() {
        return yMult;
    }

}
