using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3CreateWord : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;

    void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
    }

    private void InstantiateWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-14f, 14f);
        wordPrefab.position = new Vector3(transform.position.x, Ypos, transform.position.z);
        wordPrefab.velocity = new Vector2(4f, 0f);
        Invoke("InstantiateWord", Random.Range(3f, 5f));
    }

}
