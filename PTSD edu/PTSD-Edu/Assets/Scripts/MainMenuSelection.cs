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
    public Button lvlSelectB;
    public GameObject lvlButtons;
    public Text instrucText;

    private void Start() {
        lvlButtons.SetActive(false);
        instrucText.enabled = false;
    }

    public void InstructionButtonClick() {
        lvlButtons.SetActive(false);
        instrucText.enabled = true;
    }

    public void LevelSelectionClick() {
        instrucText.enabled = false;
        lvlButtons.SetActive(true);
    }

    public void LevelBegin(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
