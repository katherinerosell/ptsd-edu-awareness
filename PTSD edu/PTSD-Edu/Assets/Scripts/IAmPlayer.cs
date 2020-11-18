using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IAmPlayer : MonoBehaviour {

    private static int blipPoints; // health points
    private Scene scene;
    
    void Start() {
        scene = SceneManager.GetActiveScene();
        blipPoints = 3;
    }

    public int getBlipPoints() { return blipPoints; }
    public void setBlipPoints(int n) { blipPoints += n;  }

    // function called by the WordText object, since it uses isTrigger collider
    public void playerHit() {
        blipPoints--; // when player is hit, decrement blips
        //Debug.Log("Blip Points = " + blipPoints);
    }

    private void Update() {
        if (blipPoints <= 0) {
            SceneManager.LoadScene(scene.name); // game over, restart level
        }
    }

}
