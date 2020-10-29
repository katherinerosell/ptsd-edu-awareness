using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleForce : MonoBehaviour {

    public float thrust = 200f;
    private Rigidbody2D rb2D;

    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        // a short burst of movement
        rb2D.AddForce(transform.right * thrust, ForceMode2D.Impulse);
    }



}
