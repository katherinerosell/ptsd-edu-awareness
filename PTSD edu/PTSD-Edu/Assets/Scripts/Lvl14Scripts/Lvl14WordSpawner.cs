using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl14WordSpawner : MonoBehaviour {

    public Transform playerTransform;
    public GameObject wordText;
    private Rigidbody2D wordRB;
    public GameObject breeze;
    private Rigidbody2D breezeRB;

    private void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        breezeRB = breeze.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
        Invoke("InstantiateBreeze", 4f);
    }

    private void InstantiateWord() {
        float xVal = Random.Range(-34f, 30f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector2(xVal, playerTransform.position.y+30);
        wordPrefab.gravityScale = 0.4f;
        float repeatNum = Random.Range(0.4f, 0.9f);        
        Invoke("InstantiateWord", repeatNum);
    }

    private void InstantiateBreeze() {
        float xVal = Random.Range(-34f, 30f);
        Rigidbody2D breezePrefab = Instantiate(breezeRB, transform);
        breezePrefab.position = new Vector2(xVal, playerTransform.position.y + 30);
        breezePrefab.gravityScale = 0.1f;
        float repeatNum = Random.Range(2f, 4f);
        Invoke("InstantiateBreeze", repeatNum);
    }

}
