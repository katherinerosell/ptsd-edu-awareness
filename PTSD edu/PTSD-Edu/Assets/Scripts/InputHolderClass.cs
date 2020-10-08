using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/**
 * Input Holder Class
 * 
 * 
 **/
public class InputHolderClass : MonoBehaviour {

    public static string mainWord = "lightning";
    public static int _lvlNum;
    private Scene scene;
    private static string[] prompts = new string[] {
        "Type in the first word that comes to your mind when you hear the words upsetting thoughts/images",
        "Type in the first word that comes to your mind when you hear the word nightmares",
        "Type in the first word that comes to your mind when you hear the words recurring events/reexperiencing",
        "Type in the first word that comes to your mind when you hear the words feeling upset",
        "This is level 7 default text, but the fifth level"
    };

    private void Awake() {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Level3") setLevel(3);
        // Debug.Log("InputHolderClass  --  Level is: " + _lvlNum);
        if (scene.name == "Level4") setLevel(4);
    }
    
    private void Update() {
        //Debug.Log("InputHolderClass -- LEVEL NUM " + _lvlNum);
    }

    public void setLevel(int lvl) {
        _lvlNum = lvl;
    }

    public int getLevel() {
        return _lvlNum;
    }

    public string getMainWord() {
        //Debug.Log("InputHolderClass ------ Main word is: " + mainWord);
        return mainWord;
    }

    public void setMainWord(InputField inputField) {
        // Debug.Log("Input Word is: " + inputField.text + "  " + "Main Word before change is: " + mainWord );
        mainWord = inputField.text;
    }

    public string getPrompt() {
        return prompts[_lvlNum-1]; // -1 accounts for the array index ; ie lvl 1  means index 0
    }

}
