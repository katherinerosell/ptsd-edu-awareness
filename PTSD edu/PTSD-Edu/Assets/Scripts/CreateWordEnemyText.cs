using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWordEnemyText : MonoBehaviour {

    private static float myTimer = 0f;
    public GameObject wordText;
    private Rigidbody2D wordRB;
    private RectTransform rectTransform;
    //public float speed = 2f;

    private int phase1Time;
    private int phase2Time;
    private int phase3Time;


    void Start() {
        myTimer = Time.deltaTime - Time.deltaTime; // reset my timer to 0
        wordRB = wordText.GetComponent<Rigidbody2D>();
        phase1Time = 10; phase2Time = 30; phase3Time = 70;
        Invoke("InstantiateEnemyWEST", 2f);
    }

    private void Update() {
        myTimer += Time.deltaTime;
        Debug.Log("CreateEnemyWordText -- Timer as INT: " + (int)myTimer);
    }

    private void InstantiateEnemyWEST() {
        //Debug.Log(" WEST SIDE ");
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-10f, 10f);
        wordPrefab.position = new Vector3(-29.000f, Ypos, 15);
        wordPrefab.velocity = new Vector2(8f, 0f);
        Invoke("InstantiateEnemyWEST", Random.Range(3f, 5f));
        if ((int)myTimer == phase1Time) {
            Invoke("InstantiateEnemyEAST", 1f);
            //Debug.Log("CreateEnemyWordText -- Instantiate from EAST");

        }
    }

    private void InstantiateEnemyEAST() {
        //Debug.Log(" EAST SIDE ");
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-10f, 10f);
        wordPrefab.position = new Vector3(60f, Ypos, 15);
        wordPrefab.velocity = new Vector2(-8f, 0f);
        Invoke("InstantiateEnemyEAST", Random.Range(1.5f, 3f));
        if ((int)myTimer == phase2Time) {
            Invoke("InstantiateEnemyNORTH", 1f);
            //Debug.Log("35 seconds passed, start ghost spawning from NORTH");
        }
    }

    private void InstantiateGhostNORTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-10f, 10f);
        wordPrefab.position = new Vector3(60f, Ypos, 15);
        wordPrefab.velocity = new Vector2(-8f, 0f);
        Invoke("InstantiateEnemyEAST", Random.Range(1.5f, 3f));
        if ((int)myTimer == phase3Time) {
            Invoke("InstantiateEnemySOUTH", 1f);
            //Debug.Log("35 seconds passed, start ghost spawning from NORTH");
        }
    }

    private void InstantiateGhostSOUTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-10f, 10f);
        wordPrefab.position = new Vector3(60f, Ypos, 15);
        wordPrefab.velocity = new Vector2(-8f, 0f);
        Invoke("InstantiateEnemySOUTH", Random.Range(1.5f, 3f));
    }

}
