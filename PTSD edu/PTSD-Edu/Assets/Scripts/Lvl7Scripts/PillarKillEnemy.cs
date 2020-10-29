using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script is attacked to the child object, a box collider.
 * When the player hits this box, all enemies within the circle 
 * collider of the child's parent will be destoryed. 
 * Author: Katherine Rosell
 * Date: October 9th, 2020
 */
public class PillarKillEnemy : MonoBehaviour {

    public Transform pointA;
    public Transform pointB;
    private bool onA; // is PillarA on point A?

    public Transform pointC;
    public Transform pointD;
    private bool onC; // is PillarB on point C?

    public Lvl7CreateTrackingWord trackingWordScript;
    private Transform parentTransform;
    // public PillarWordTextCol pillarCol;
    private int tempPillarInt;

    private void Start() {
        onA = false; onC = false;
        parentTransform = transform.parent; // each minor pillar object knows its parent
    }

    private void OnCollisionEnter2D(Collision2D c) {
        // if player collides with this box collider, child of pillars,
        // this child needs to get the list of enemies within the circle parent
        // Then destroy any enemies still within it
        if (c.gameObject.tag == "Player") {
            if (gameObject.name == "pillarA") tempPillarInt = 0; // pillarA = 0
            if (gameObject.name == "pillarB") tempPillarInt = 1; // pillarB = 1
            trackingWordScript.DestroyZoneWords(tempPillarInt);
            MovePillar();
        }
    }

    private void OnCollisionExit2D(Collision2D c) {
        tempPillarInt = 2;
    }

    private void MovePillar() {
        if (parentTransform.name == "PillarA") {
            if (onA == false) {
                parentTransform.position = pointA.position;
                onA = true;
            }
            else {
                parentTransform.position = pointB.position;
                onA = false;
            }
        }
        if (parentTransform.name == "PillarB") {
            if (onC == false) {
                parentTransform.position = pointC.position;
                onC = true;
            }
            else {
                parentTransform.position = pointD.position;
                onC = false;
            }
        }
    }

}
