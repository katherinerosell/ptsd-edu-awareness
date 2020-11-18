using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8CreateWord : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;

    private void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWordSouth", 3f); // don't invoke right at the start
        // the game needs a couple of seconds to begin and send information
        // to the InputHolderClass
    }

    private void InstantiateWordSouth() {
        float xpos = Random.Range(-65f, 73f);
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.position = new Vector3(xpos, -35f, 15f);
        wordPrefab.velocity = new Vector2(0f, 5f);
        float repeatNum = Random.Range(2f, 5f);
        Invoke("InstantiateWordSouth", repeatNum);
    }
}
