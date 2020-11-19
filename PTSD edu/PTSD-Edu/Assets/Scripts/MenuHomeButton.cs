using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * Simple go to MainMenu scene script attached to the Home-Button 
 * in the MenuPanel
 * */
public class MenuHomeButton : MonoBehaviour {
    public void goHome() {
        SceneManager.LoadScene("MainMenu"); // the title screen
    }    
}
