using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour {

    public GameObject promptPanel;
    private Text promptTxt;
    private Text displayedTxt;
    
    void Start() {        
        displayedTxt = GameObject.Find("DisplayedText").GetComponent<Text>();
        promptTxt = GameObject.Find("CPSSPrompt").GetComponent<Text>();
        promptTxt.text = GetComponent<InputHolderClass>().getPrompt();
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
        promptTxt.text = GetComponent<InputHolderClass>().getPrompt();
        displayedTxt.text = "";        
        Time.timeScale = 0f; //pause the game, no time runs?
        promptPanel.SetActive(true);
    }

}
