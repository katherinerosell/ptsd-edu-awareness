using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl7CreateTrackingWord : MonoBehaviour {
    public GameObject wordText;
    private Rigidbody2D wordRB;
    void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        Invoke("InstantiateWord", 2f);
    }

    private void InstantiateWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        wordPrefab.gameObject.AddComponent<TrackingEnemy>();
        Invoke("InstantiateWord", 3f);
    }

}
