using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl10SpawnEast : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;
    private float spawnRate;

    private void Start() {
        spawnRate = 3f;
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWordEast", 2f);
        Invoke("InstantiateWordWest", spawnRate+2);
    }

    private void InstantiateWordEast() {
        float ypos = Random.Range(-39f, 39f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector3(transform.position.x, ypos, 15f);
        wordPrefab.velocity = new Vector2(-9f, 0f);
        spawnRate = Random.Range(3f, 5f);
        Invoke("InstantiateWordEast", spawnRate);
    }

    private void InstantiateWordWest() {
        float ypos = Random.Range(-39f, 39f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector3(-77f, ypos, 15f);
        wordPrefab.velocity = new Vector2(7f, 0f);
        Invoke("InstantiateWordWest", spawnRate+2);
    }


}
