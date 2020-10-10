using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarKillEnemy : MonoBehaviour {

    private PillarScript pillarScript;
    private List<GameObject> tempList;

    private void Start() {
        pillarScript = GetComponentInParent<PillarScript>();        
    }

    private void OnCollisionEnter2D(Collision2D c) {
        // if player collides with this box collider, child of pillars,
        // this child needs to get the list of enemies within the circle parent
        // Then destroy any enemies still within it
        if (c.gameObject.tag == "Player") {
            tempList = pillarScript.getEnemyList();
            pillarScript.WipeClean();
            if (tempList != null) {
                for (int i = 0; i < tempList.Capacity-1; i++) {
                    try {
                        Destroy(tempList[i]);
                    } catch(ArgumentOutOfRangeException) {
                        Debug.Log("ArgumentOutOfRangeException " + i + "  Capacity=" + tempList.Capacity);
                    }                    
                }
            }
            else {  }            
        }
    }

}
