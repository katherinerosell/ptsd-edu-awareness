using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private InputHolderClass holderClass;
    private GameLoop gameLoopScript;
    //public float speed = 2f;

    private int phase1Time;
    private int phase2Time;
    private int phase3Time;
    private bool level2On;

    private void Awake() {
        gameLoopScript = GameObject.Find("_GM").GetComponent<GameLoop>();
        holderClass = GameObject.Find("_GM").GetComponent<InputHolderClass>(); // _GM object has the script attached
        holderClass.setLevel(1);
        level2On = false; // level 2 is not active YET
        // set the level we are on to LEVEL 1
    }

    void Start() {
        myTimer = 0f;
        wordRB = wordText.GetComponent<Rigidbody2D>();
        phase1Time = 10;
        phase2Time = 30;
        phase3Time = 70;
        Invoke("InstantiateEnemyWEST", 2f);
    }

    private void Update() {
        myTimer += Time.deltaTime;
       // Debug.Log("Timer as INT: " + (int)myTimer);

        if ((100 <= myTimer && myTimer <= 101) && level2On == false) {
            level2On = true;
            Debug.Log("  Level 2 Start  ----   Display Player Shadow Box  ");
            holderClass.setLevel(2);
            gameLoopScript.newLevel();
        }
        if (131 <= myTimer && myTimer <= 132) {
            // move on to level 3 after ~30 seconds of gameplay
            SceneManager.LoadScene(1);
        }
    }

    private void InstantiateEnemyWEST() {
        //Debug.Log(" WEST SIDE ");
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Ypos = Random.Range(-18f, 18f);
        wordPrefab.position = new Vector3(-45.000f, Ypos, 15);
        wordPrefab.velocity = new Vector2(8f, 0f);
        Invoke("InstantiateEnemyWEST", Random.Range(2f, 3f));
        if (phase1Time-3 <= myTimer && myTimer <= phase1Time) {
            // Debug.Log("CreateEnemyWordText -- Instantiate from EAST");
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
            // Debug.Log("CreateEnemyWordText -- Instantiate from NORTH");
            Invoke("InstantiateEnemyNORTH", 2f);
        }
    }

    private void InstantiateEnemyNORTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-40f, 63f);
        wordPrefab.position = new Vector3(Xpos, 18, 15);
        wordPrefab.velocity = new Vector2(0f, -6.5f);//move downwards
        Invoke("InstantiateEnemyNORTH", Random.Range(4f, 6f));
        if (phase3Time - 5 <= myTimer && myTimer <= phase3Time) {
            // Debug.Log("CreateEnemyWordText -- Instantiate from SOUTH");
            Invoke("InstantiateEnemySOUTH", 1f);
        }
    }

    private void InstantiateEnemySOUTH() {
        Rigidbody2D wordPrefab = Instantiate(wordRB, transform);
        float Xpos = Random.Range(-40f, 63f);
        wordPrefab.position = new Vector3(Xpos, -17, 15);
        wordPrefab.velocity = new Vector2(0f, 4f);// move upwards
        Invoke("InstantiateEnemySOUTH", Random.Range(4f, 6f));
    }

}
