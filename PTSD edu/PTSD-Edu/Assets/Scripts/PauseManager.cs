using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

    [SerializeField]
    Button PauseButton;
    //[SerializeField]
    //Text timeText; //Will assign our Time Text to this variable so we can modify the text it displays.

    bool isPaused; //Used to determine paused state

    void Start() {
        UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
        isPaused = false; //make sure isPaused is always false when our scene opens
    }

    void Update() {

        //timeText.text = "Time Since Startup: " + Time.timeSinceLevelLoad; //Tells us the time since the scene loaded

        //If player presses escape and game is not paused. Pause game. If game is paused and player presses escape, unpause.
        /**
         if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
             Pause();
         else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
             UnPause();
         **/
        
    }

    public void Pause() {
        isPaused = true;
        UIPanel.gameObject.SetActive(true); //turn on the pause menu
        Time.timeScale = 0f; //pause the game
        PauseButton.gameObject.SetActive(false);
    }

    public void UnPause() {
        isPaused = false;
        UIPanel.gameObject.SetActive(false); //turn off pause menu
        Time.timeScale = 1f; //resume game
        PauseButton.gameObject.SetActive(true);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void Restart() {
        SceneManager.LoadScene("Level1-2", LoadSceneMode.Single); 
    }

}
