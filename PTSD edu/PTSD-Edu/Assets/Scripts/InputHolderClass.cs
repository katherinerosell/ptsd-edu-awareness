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
        "Level 5 prompt here",
        "Level 6 prompt here",
        "Trying to avoid activities, people, or places that remind you of the traumatic event",
        "Level 8 prompt here",
        "Level 9 prompt here",
        "Type in the first word that comes to your mind when you hear the words not feeling close to people around you",
        "Level 11 prompt here",
        "Level 12 prompt here",
        "Level 13 prompt here",
        "Type in the first word that comes to your mind when you hear the words feeling irritable or having fits of anger",
        "Level 15 prompt here",
        "Type in the first word that comes to your mind when you hear the words being overly careful",
        "Type in the first word that comes to your mind when you hear the words being jumpy or easily startled",
    };

    private void Awake() {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Level3") setLevel(3);
        // Debug.Log("InputHolderClass  --  Level is: " + _lvlNum);
        if (scene.name == "Level4") setLevel(4);
        if (scene.name == "Level7") setLevel(7);
        if (scene.name == "Level8") setLevel(8);
        if (scene.name == "Level10") setLevel(10);
    }

    public void setLevel(int lvl) {
        _lvlNum = lvl;
    }

    public int getLevel() {
        return _lvlNum;
    }

    public string getMainWord() {
        return mainWord;
    }

    public void setMainWord(InputField inputField) {        
        mainWord = inputField.text;
    }

    public string getPrompt() {
        return prompts[_lvlNum-1]; // -1 accounts for the array index ; ie lvl 1  means index 0
    }

}
