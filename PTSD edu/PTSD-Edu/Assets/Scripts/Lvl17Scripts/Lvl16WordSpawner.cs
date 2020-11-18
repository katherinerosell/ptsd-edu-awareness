using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl16WordSpawner : MonoBehaviour {

    public Transform playerTransform;
    public GameObject wordText;
    private Rigidbody2D wordRB;
    public GameObject breeze;
    private Rigidbody2D breezeRB;
    private int[] positions;

    private void Start() {
        positions = new int[] {2, -6}; // spawn at either y val
        wordRB = wordText.GetComponent<Rigidbody2D>();
        breezeRB = breeze.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
        Invoke("InstantiateBreeze", 5f);
    }

    private void InstantiateWord() {
        int yval = Random.Range(0, 2);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector2(playerTransform.position.x+40, positions[yval]); // y is -6
        wordPrefab.velocity = new Vector2(-15f, 0f);
        float repeatNum = Random.Range(5f, 9f);
        Invoke("InstantiateWord", repeatNum);
    }

    private void InstantiateBreeze() {
        Rigidbody2D breezePrefab = Instantiate(breezeRB, transform);
        breezePrefab.gravityScale = 0f;
        breezePrefab.position = new Vector2(playerTransform.position.x + 30, 1f);
        breezePrefab.velocity = new Vector2(-12f, 0);
        float repeatNum = Random.Range(4f, 8f);   
        Invoke("InstantiateWord", repeatNum);
    }

}
