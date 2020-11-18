using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCircleScript : MonoBehaviour {

    private CircleCollider2D circleCollider;
    private int orbies; // all 4 orbs in the scene

    private void Start() {
        orbies = 4;
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "orb") {
            Rigidbody2D orbRB = c.gameObject.GetComponent<Rigidbody2D>();
            orbRB.position = gameObject.transform.position;            
            orbies--;
            orbRB.bodyType = RigidbodyType2D.Static;
        }
        if (orbies == 0) SceneManager.LoadScene("Level14");
    }

}
