using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpin : MonoBehaviour {

    private float speed;
    private Transform roomT;

    private void Start() {
        speed = 0.03f;
        roomT = GetComponent<Transform>();
    }

    private void Update() {
        roomT.Rotate(0f, 0f, speed);
    }

}
