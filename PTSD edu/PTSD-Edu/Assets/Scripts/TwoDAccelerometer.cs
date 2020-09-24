using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDAccelerometer : MonoBehaviour {

    private Rigidbody2D _ball;

    private void Start() {
        _ball = GetComponent<Rigidbody2D>();
    }

    private void Update() {

        //Vector3 tilt = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z); //front and back acceleration have to be flipped
        //_ball.AddForce(new Vector2(Input.acceleration.x, Input.acceleration.y));
        //_ball.AddForce(new Vector2(tilt.x, tilt.y));
        _ball.velocity = new Vector2(Input.acceleration.x * 20, (Input.acceleration.y + 0.3f) * 22);
        //Debug.DrawRay(transform.position + Vector3.right, tilt, Color.magenta);
        //Debug.Log(Input.acceleration);

    }

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "InvisWall") {
            //Debug.Log("Hit Invisible Wall");
        }
    }


}
