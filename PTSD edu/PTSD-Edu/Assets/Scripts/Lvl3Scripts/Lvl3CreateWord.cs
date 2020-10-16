using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl3CreateWord : MonoBehaviour {

    public GameObject wordText;
    private Rigidbody2D wordRB;

    void Start() {
        wordRB = wordText.GetComponent<Rigidbody2D>();
        if(SceneManager.GetActiveScene().name == "Level3") Invoke("InstantiateWord", 2f);
        if (SceneManager.GetActiveScene().name == "Level10") Invoke("InstantiateLvl10Word", 1f);
    }

    private void InstantiateWord() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-14f, 14f);
        wordPrefab.position = new Vector3(transform.position.x, Ypos, transform.position.z);
        wordPrefab.velocity = new Vector2(4f, 0f);
        Invoke("InstantiateWord", Random.Range(3f, 5f));
    }
    // make the word appear slowly from the left side of the screen 
    private void InstantiateLvl10Word() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-21f, 25.3f);
        wordPrefab.position = new Vector3(transform.position.x, Ypos, transform.position.z);
        wordPrefab.velocity = new Vector2(5f, 0f);
        InstantiateLvl10WordSouth();
        Invoke("InstantiateWord", Random.Range(4f, 6f));
    }
    // only accessed in Level 10 for extra difficulty
    // move the word from the bottom up, slowly
    private void InstantiateLvl10WordSouth() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-65f, 63f);
        wordPrefab.position = new Vector3(Xpos, 30f, transform.position.z);
        wordPrefab.velocity = new Vector2(0f, -7f);
        Invoke("InstantiateLvl10WordSouth", Random.Range(3f, 5f));
    }

}
