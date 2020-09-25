using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour {

    public GameObject promptPanel;
    
    void Start() {
        Time.timeScale = 0f; //pause the game, no time runs?
        promptPanel.SetActive(true);
    }

    /* Only called when the Enter button has been pressed
     */
    public void beginLevel() {
        promptPanel.SetActive(false);
        Time.timeScale = 1f; // resume or begin the level
    }

    public void newLevel() {
        Time.timeScale = 0f; //pause the game, no time runs?
        promptPanel.SetActive(true);
    }

}
