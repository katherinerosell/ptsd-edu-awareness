﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Script is attached to the CreateTrackingEnemy empty 
 * Game Object in Level7. 
 */
public class Lvl7CreateTrackingWord : MonoBehaviour {
    public GameObject wordText;
    private Rigidbody2D wordRB;
    private int spawnTime; // spawn a new word in this amount of time
    private float myTimer;

    public Transform westSpawn;
    public Transform eastSpawn;
    public Transform northSpawn;
    public Transform southSpawn;

    void Start() {
        myTimer = 0f;
        spawnTime = 6;
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
    }

    private void Update() {
        myTimer += Time.deltaTime;
        if (myTimer >= 40f && myTimer <= 41f) {
            SceneManager.LoadScene("Level8");
        }
    }

    private void InstantiateWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.gameObject.AddComponent<TrackingEnemy>();
        Invoke("InstantiateWord", spawnTime);
    }

    public void DestroyZoneWords(int pillarNum) {
        Rigidbody2D[] ChildrenObjs = GetComponentsInChildren<Rigidbody2D>();
        foreach (Rigidbody2D rb in ChildrenObjs) {
            GameObject wordObj = rb.gameObject;
            // if that specific game object is within the circle collider zone, destroy it
            if (wordObj.GetComponent<TrackingEnemy>().WithinZone() && (wordObj.GetComponent<TrackingEnemy>().getPillarInt() == pillarNum)) {
                Destroy(wordObj);
            }            
        }
    }

}