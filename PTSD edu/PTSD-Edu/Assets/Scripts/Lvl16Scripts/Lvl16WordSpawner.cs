using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl16WordSpawner : MonoBehaviour {

    public Transform playerTransform;
    public GameObject wordText;
    private Rigidbody2D wordRB;
    public GameObject breeze;
    private Rigidbody2D breezeRB;

    private void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        breezeRB = breeze.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
        Invoke("InstantiateBreeze", 5f);
    }

    private void InstantiateWord() {
        float yVal = Random.Range(-34f, 30f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector2(playerTransform.position.x+26, yVal);
        float repeatNum = Random.Range(2f, 4f);
        Debug.Log("WordText Prefab made!!!!");
        Invoke("InstantiateWord", repeatNum);
    }

    private void InstantiateBreeze() {
        float yVal = Random.Range(-34f, 30f);
        Rigidbody2D breezePrefab = Instantiate(breezeRB, transform);
        breezePrefab.gravityScale = 0f;
        breezePrefab.position = new Vector2(playerTransform.position.x + 30, yVal);
        breezePrefab.velocity = new Vector2(-4f, 0);
        float repeatNum = Random.Range(3f, 6f);        
        Debug.Log("WordText Prefab made!!!!");
        Invoke("InstantiateWord", repeatNum);
    }

}
