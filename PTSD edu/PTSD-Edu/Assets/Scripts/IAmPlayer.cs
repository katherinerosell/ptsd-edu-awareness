using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IAmPlayer : MonoBehaviour {

    private static int blipPoints; // health points
    private Scene scene;
    //public Text hitText;
    
    void Start() {
        scene = SceneManager.GetActiveScene();
        blipPoints = 3;
        //hitText = hitText.GetComponent<Text>();
    }

    // function called by the WordText object, since it uses isTrigger collider
    public void playerHit() {
        blipPoints--; // when player is hit, decrement blips
        Debug.Log("Blip Points = " + blipPoints);
    }

    private void Update() {
        if (blipPoints <= 0) {
            SceneManager.LoadScene(scene.name); // game over, restart level
        }
    }

}
