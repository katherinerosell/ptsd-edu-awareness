﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IamGhost : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Enemy") {
            //Debug.Log("e n e m y - ignore collision");
        }

        if (c.gameObject.tag == "KillWall") {
            //Debug.Log("self destruct");
            Destroy(gameObject);
        }

        if (c.gameObject.tag == "Player") {
            //decrease 'health' points
            //Debug.Log("player collision!!!");
            Destroy(gameObject);
        }
    }

}
