using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl14WordSpawner : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;

    private void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
    }

    private void InstantiateWord() {
        float xVal = Random.Range(-34f, 30f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector2(xVal, transform.position.y);
        wordPrefab.velocity = new Vector2(0f, -4f);
        float repeatNum = Random.Range(1f, 3f);
        Invoke("InstantiateWord", repeatNum);
    }

}
