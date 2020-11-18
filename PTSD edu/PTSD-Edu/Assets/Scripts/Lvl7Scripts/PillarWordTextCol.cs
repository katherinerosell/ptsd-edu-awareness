using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script is attached to PillarA and PillarB to handle
 * teleportation when the player collides with them. They are the
 * main squares in the scene.
 */ 
public class PillarWordTextCol : MonoBehaviour {

    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    private CircleCollider2D circleCollider; // the circle colliders of the pillars
    private Transform[] spawnPoints;
    private int[] pointsOccupied;
    private int oldPos = 1;

    private void Start() {
        spawnPoints = new Transform[4] { pointA, pointB, pointC, pointD }; // hold all points
        circleCollider = GetComponent<CircleCollider2D>();
        pointsOccupied = new int[4] { 0, 1, 1, 0}; // at start, what points are occupied?
    }

    /* The spawnPoint is only occupied when the concurrent array, 
     * pointsOccupied at the new position generated, is equal to 1.
     * 0 at an array index means that point is open. 
    */
    public void NewPosition(GameObject pillar) {
        int newPos = Random.Range(0, 4);
        Debug.Log("New Position: " + newPos);
        if (pointsOccupied[newPos] == 0) {
            pillar.transform.parent.position = spawnPoints[newPos].position;
            TrackPointOccupations(newPos);
        }
        else { NewPosition(pillar); }
        Debug.Log("game object name: " + pillar.name);
    }

    private void TrackPointOccupations(int n) {
        pointsOccupied[oldPos] = 0;
        pointsOccupied[n] = 1;
        oldPos = n;
    }

}
