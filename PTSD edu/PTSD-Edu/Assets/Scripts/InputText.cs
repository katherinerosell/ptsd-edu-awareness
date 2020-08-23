using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//once the enter button is clicked, the text changes to the one entered
public class InputText : MonoBehaviour {
    public Text testText;
    public InputField inputField;

    void Start() {
        testText = testText.GetComponent<Text>();
        inputField = inputField.GetComponent<InputField>();
    }

    public void updateText() {
        testText.text = inputField.text;
    }

}
