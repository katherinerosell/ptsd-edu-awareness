using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/**
 * This script is attached to the MM_Manager, or Main Menu Manager
 * gameobject in the MainMenuScene. It is designed to allow the buttons
 * on screen to do their jobs - going to a level, hide things from the scene.
 * 11/18/2020
 * */
public class MainMenuSelection : MonoBehaviour {

    public Button beginB;
    public Button instructionsB;
    private bool instrEnabled; // toggle enabled when button clicked
    
    public Button lvlSelectB;
    private bool lvlsEnabled;// toggle enabled when button clicked

    public GameObject lvlButtons;
    public Text instrucText;

    private void Start() {
        instrEnabled = false;
        lvlsEnabled = false;
        lvlButtons.SetActive(false);
        instrucText.enabled = false;
    }

    public void InstructionButtonClick() {
        lvlsEnabled = false;
        lvlButtons.SetActive(lvlsEnabled);        
        instrEnabled = !instrEnabled;
        instrucText.enabled = instrEnabled;
    }

    public void LevelSelectionClick() {
        instrEnabled = false;
        instrucText.enabled = instrEnabled;        
        lvlsEnabled = !lvlsEnabled;
        lvlButtons.SetActive(lvlsEnabled);
    }

    public void LevelBegin(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
