using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Create Word Enemy Text
 * Used in: Level 1, Level 2
 * Creates WordText prefabs that move in from all 4 sides of the screen
 * Author: Katherine Rosell
 * 
 * */

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
        phase1Time = 10;
        phase2Time = 30;
        phase3Time = 70;
        Invoke("InstantiateEnemyWEST", 2f);
    }

    private void Update() {
        myTimer += Time.deltaTime;
        Debug.Log("CreateEnemyWordText -- Timer as INT: " + (int)myTimer);
    }

    private void InstantiateEnemyWEST() {
        //Debug.Log(" WEST SIDE ");
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-18f, 18f);
        wordPrefab.position = new Vector3(-45.000f, Ypos, 15);
        wordPrefab.velocity = new Vector2(8f, 0f);
        Invoke("InstantiateEnemyWEST", Random.Range(2f, 3f));
        if (phase1Time-3 <= myTimer && myTimer <= phase1Time) {
            Debug.Log("CreateEnemyWordText -- Instantiate from EAST");
            Invoke("InstantiateEnemyEAST", 2f);
        }
    }

    private void InstantiateEnemyEAST() {
        //Debug.Log(" EAST SIDE ");
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-18f, 18f);
        wordPrefab.position = new Vector3(63f, Ypos, 15);
        wordPrefab.velocity = new Vector2(-8f, 0f);
        Invoke("InstantiateEnemyEAST", Random.Range(2f, 4f));
        if (phase2Time-4 <= myTimer && myTimer <= phase2Time) {
            Debug.Log("CreateEnemyWordText -- Instantiate from NORTH");
            Invoke("InstantiateEnemyNORTH", 2f);
        }
    }

    private void InstantiateEnemyNORTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-40f, 63f);
        wordPrefab.position = new Vector3(Xpos, 18, 15);
        wordPrefab.velocity = new Vector2(0f, -4.5f);//move downwards
        Invoke("InstantiateEnemyNORTH", Random.Range(4f, 5f));
        if (phase3Time - 5 <= myTimer && myTimer <= phase3Time) {
            Debug.Log("CreateEnemyWordText -- Instantiate from SOUTH");
            Invoke("InstantiateEnemySOUTH", 1f);
        }
    }

    private void InstantiateEnemySOUTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-40f, 63f);
        wordPrefab.position = new Vector3(Xpos, -17, 15);
        wordPrefab.velocity = new Vector2(0f, 3f);// move upwards
        Invoke("InstantiateEnemySOUTH", Random.Range(4f, 6f));
    }

}
