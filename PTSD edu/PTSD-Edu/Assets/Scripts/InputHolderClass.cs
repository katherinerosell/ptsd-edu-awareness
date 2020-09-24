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

    public string getMainWord() {
        //Debug.Log("InputHolderClass ------ Main word is: " + mainWord);
        return mainWord;
    }

    public void setMainWord(InputField inputField) {
        Debug.Log("Input Word is: " + inputField.text + "  " + "Main Word before change is: " + mainWord );
        mainWord = inputField.text;
    }

}
