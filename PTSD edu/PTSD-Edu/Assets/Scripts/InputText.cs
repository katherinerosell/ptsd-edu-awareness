using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//once the enter button is clicked, the text changes to the one entered
public class InputText : MonoBehaviour {
    public Text testText;
    private Text text;
    public InputField inputField;
    public string userInput;
    public Canvas canvas;
    public Font mysansFont;

    // the word that the user inputs, used as an enemy
    public RectTransform wordRectT;

    void Start() {
        canvas = canvas.GetComponent<Canvas>();
        testText = testText.GetComponent<Text>();
        inputField = inputField.GetComponent<InputField>();
        if (mysansFont == null) { Debug.Log("sans font unreachable"); }
        wordRectT = wordRectT.GetComponent<RectTransform>();
    }

    public void updateText() {
        userInput = inputField.text; 
        testText.text = inputField.text;
    }

    

}
