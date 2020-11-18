using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* ---- Meant for Level13 which does not yet exist ----
 * Script used to specifically instantiate the WordText prefab
 * in Level 13. This level is particular because it requires the 
 * word to fall down, with no velocity attached, and collide with 
 * other objects. It loses its isTrigger and no gravity attributes.
 * Date: 10/20/2020
 * Author: Katherine Rosell
 */
public class Lvl10WordCreation : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;
    private BoxCollider2D wordBox;
    private float spawnRate;
    private float myTimer;

    private void Start() {
        myTimer = 0f;
        wordRB = wordText.GetComponent<Rigidbody2D>();
        wordBox = wordText.GetComponent<BoxCollider2D>();
        // I changed the rigidbody attributes of the ACTUAL PREFAB.
        // not the instantiated versions... only mutate these values 
        // per instantiated object
        Invoke("InstantiateWord", 2f);
    }

    private void Update() {
        myTimer += Time.deltaTime;
        if ((int)myTimer >= 100 && (int)myTimer <= 102) SceneManager.LoadScene("Level14");
    }

    private void InstantiateWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.GetComponent<BoxCollider2D>().isTrigger = false; // remove isTrigger of this box
        wordPrefab.gravityScale = 2;
        wordPrefab.mass = 20;
        spawnRate = Random.Range(2f, 10f);
        Invoke("InstantiateWord", spawnRate);
    }


}
