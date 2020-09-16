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

    
    public void spawnText() {

        //GameObject wordPrefab = Instantiate(enemyWord);
        //wordPrefab.transform.position = new Vector3(0, 0, 0);

        RectTransform wordRBPrefab = Instantiate(wordRectT);

        /**
        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvas.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        text.font = mysansFont;
        text = textGO.GetComponent<Text>();
        text.text = "text spawned";
        text.fontSize = 48;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
        **/
    }
    

}
