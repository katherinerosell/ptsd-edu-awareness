using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * Input Holder Class
 * 
 * 
 **/
public class InputHolderClass : MonoBehaviour {

    public static string mainWord = "lightning";
    public static int _lvlNum = 1;
    private static string[] prompts = new string[] {
        "Type in the first word that comes to your mind when you hear the words upsetting thoughts/images",
        "Type in the first word that comes to your mind when you hear the word nightmares"

    };

    private void Update()
    {
        Debug.Log("InputHolderClass -- LEVEL NUM " + _lvlNum);
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
