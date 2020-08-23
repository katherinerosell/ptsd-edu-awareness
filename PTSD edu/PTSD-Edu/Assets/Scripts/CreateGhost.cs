using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGhost : MonoBehaviour {

    private float myTimer;
    private int invokeNum;
    public Rigidbody2D aGhost;

    private bool run; 

    private void Start() {
        invokeNum = 0;
        run = true;
        myTimer = Time.deltaTime;
        aGhost = aGhost.GetComponent<Rigidbody2D>();
        Invoke("InstantiateGhostWEST", 2f);
        //Invoke("InstantiateGhostEAST", 1f);
        //Invoke("InstantiateGhostNORTH", 4f);
        //Invoke("InstantiateGhostSOUTH", 1f);
    }

    private void Update()  {
        myTimer += Time.deltaTime;
        //Debug.Log("Seconds: " + (int) myTimer);
    }

    private void InstantiateGhostWEST() {

        Rigidbody2D ghostPrefab = Instantiate(aGhost);
            float Ypos = Random.Range(-10f, 10f);
            ghostPrefab.position = new Vector3(-29.000f, Ypos, 15);
            ghostPrefab.velocity = new Vector2(8f, 0f);
        Invoke("InstantiateGhostWEST", Random.Range(1.2f, 1f));
        if ((int)myTimer == 10) {
            Invoke("InstantiateGhostEAST", 1f);
            Debug.Log("6 seconds passed, start ghost spawning from EAST");
        }
    }

    private void InstantiateGhostEAST() {
        Rigidbody2D ghostPrefab = Instantiate(aGhost);
        float Ypos = Random.Range(-10f, 10f);
        ghostPrefab.position = new Vector3(29.000f, Ypos, 15);
        ghostPrefab.velocity = new Vector2(-8f, 0f);
        Invoke("InstantiateGhostEAST", Random.Range(1.2f, 1f));
        if ((int)myTimer == 40) {
            Invoke("InstantiateGhostNORTH", 1f);
            Debug.Log("35 seconds passed, start ghost spawning from NORTH");
        }
    }

    private void InstantiateGhostNORTH() {
        Rigidbody2D ghostPrefab = Instantiate(aGhost);
        float Xpos = Random.Range(-33f, 38f);
        ghostPrefab.position = new Vector3(Xpos, 20, 15);
        ghostPrefab.velocity = new Vector2(0f, -4f);
        Invoke("InstantiateGhostNORTH", Random.Range(1.2f, 3f));
        if ((int)myTimer == 70) {
            Invoke("InstantiateGhostSOUTH", 1f);
            Debug.Log("70 seconds passed, start ghost spawning from SOUTH");
        }
    }

    private void InstantiateGhostSOUTH() {
        Rigidbody2D ghostPrefab = Instantiate(aGhost);
        float Xpos = Random.Range(-33f, 38f);
        ghostPrefab.position = new Vector3(Xpos, -15, 15);
        ghostPrefab.velocity = new Vector2(0f, 4f);
        Invoke("InstantiateGhostSOUTH", Random.Range(1.2f, 3f));
    }

}
