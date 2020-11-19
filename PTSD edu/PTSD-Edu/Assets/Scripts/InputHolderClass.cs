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
        "Type in the first word that you associate with upsetting thoughts/images",
        "Type in the first word that you associate with nightmares",
        "Type in the first word that you associate with recurring events/reexperiencing",
        "Type in the first word that you associate with feeling upset",
        "Level 5 prompt here",
        "Level 6 prompt here",
        "Type the first word that you associate with trying to avoid activities, people, or places that remind you of a traumatic event",
        "Type the first word that you associate with not being able to remember an important part of an event",
        "Level 9 prompt here",
        "Type in the first word that you associate with not feeling close to people around you",
        "Level 11 prompt here",
        "Level 12 prompt here",
        "Level 13 prompt here",
        "Type in the first word that you associate with feeling irritable or having fits of anger",
        "Level 15 prompt here",
        "Type in the first word that you associate with being overly careful",
        "Type in the first word that you associate with being jumpy or easily startled",
    };

    private void Awake() {
        scene = SceneManager.GetActiveScene();
        //if (scene.name == "Level1-2") setLevel(1);
        if (scene.name == "Level3") setLevel(3);
        // Debug.Log("InputHolderClass  --  Level is: " + _lvlNum);
        if (scene.name == "Level4") setLevel(4);
        if (scene.name == "Level7") setLevel(7);
        if (scene.name == "Level8") setLevel(8);
        if (scene.name == "Level10") setLevel(10);
        if (scene.name == "Level14") setLevel(14);
        if (scene.name == "Level16") setLevel(16);
        if (scene.name == "Level17") setLevel(17);
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
