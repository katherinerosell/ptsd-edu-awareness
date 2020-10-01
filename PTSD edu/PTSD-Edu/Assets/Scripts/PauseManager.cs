using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    [SerializeField]
    Transform MenuPanel; //Will assign our panel to this variable so we can enable/disable it

    [SerializeField]
    Button PauseButton;

    bool isPaused; // Used to determine paused state

    void Start() {
        MenuPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
        isPaused = false; //make sure isPaused is always false when our scene opens
    }

    public void Pause() {
        isPaused = true;
        MenuPanel.gameObject.SetActive(true); // turn on the pause menu
        Time.timeScale = 0f; //pause the game
        PauseButton.gameObject.SetActive(false);
    }

    public void UnPause() {
        isPaused = false;
        MenuPanel.gameObject.SetActive(false); //turn off pause menu
        Time.timeScale = 1f; //resume game
        PauseButton.gameObject.SetActive(true);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        UnPause(); // when scene restarts, time gets frozen for some reason. But Resuming helps move things again 
    }

}
