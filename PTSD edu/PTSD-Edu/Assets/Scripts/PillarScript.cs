using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour {
    private bool inCollider = false; // is the player in the circle collider?
    private CircleCollider2D circleCollider;
    private List<GameObject> enemyList; // list of enemies WITHIN the circle collider

    private void Start() {
        circleCollider = GetComponent<CircleCollider2D>();
        enemyList = new List<GameObject>();
    }
    private void Update() {

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (circleCollider.bounds.Contains(new Vector2(touchPos.x, touchPos.y))) {
                TouchClickCheck();
            }
            else { Debug.Log("no pillar touch; regular touch"); }
        }
    }

    public void TouchClickCheck() {
        Debug.Log("PILLAR TOUCH");
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Player") {
            inCollider = true;
            Debug.Log("Player collided with trigger!");
        }
        if (c.gameObject.tag == "Enemy") {
            enemyList.Add(c.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D c) {
        if (c.gameObject.tag == "Player") {
            inCollider = false;
            Debug.Log("Player exited collider");
        }
        if (c.gameObject.tag == "Enemy") {
            enemyList.Remove(c.gameObject);
        }
    }
    // returns the boolean checking if player is within circle collider
    public bool getInCollider() {
        return inCollider;
    }

    public List<GameObject> getEnemyList() {
        return enemyList;
    }
    // this function removes all information from the enemy list
    // since the list has already been copied by the child
    public void WipeClean() {
        enemyList.Clear();
    }

}
