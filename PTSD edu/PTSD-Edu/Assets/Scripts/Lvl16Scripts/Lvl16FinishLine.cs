using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl16FinishLine : MonoBehaviour {

    public Rigidbody2D playerRB;

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "Player") SceneManager.LoadScene("Level17");
    }

}
