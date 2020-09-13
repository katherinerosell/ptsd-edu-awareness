using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardInput : MonoBehaviour {
    private string stringToEdit = "Hello World";
    private TouchScreenKeyboard keyboard;
    public Text Txt;
    private string psuedo;

    private void Start() {
        
    }

    void OnGUI() {
        //TouchScreenKeyboard.Open("Hello", TouchScreenKeyboardType.Default, true, false, false, false, "", 0);
        //stringToEdit = GUI.TextField(new Rect(10, 10, 200, 30), stringToEdit, 30);
        //keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    public void TextChange(string newText) {
        psuedo = newText;
        Debug.Log("Text Changed " + newText);
    }

    public string getString() {
        return psuedo;
    }

    public void OnSelected() {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
        Debug.Log("Keyboard is Open???");
    }

}
