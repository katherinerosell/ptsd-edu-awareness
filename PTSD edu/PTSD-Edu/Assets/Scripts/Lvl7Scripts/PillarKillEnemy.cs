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

    public Lvl7CreateTrackingWord trackingWordScript;
    // public PillarWordTextCol pillarCol;
    private int tempPillarInt;

    private void OnCollisionEnter2D(Collision2D c) {
        // if player collides with this box collider, child of pillars,
        // this child needs to get the list of enemies within the circle parent
        // Then destroy any enemies still within it
        if (c.gameObject.tag == "Player") {
            if (gameObject.name == "pillarA") tempPillarInt = 0; // pillarA = 0
            if (gameObject.name == "pillarB") tempPillarInt = 1; // pillarB = 1
            trackingWordScript.DestroyZoneWords(tempPillarInt);
            // pillarCol.NewPosition(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D c) {
        tempPillarInt = 2;
    }

}
