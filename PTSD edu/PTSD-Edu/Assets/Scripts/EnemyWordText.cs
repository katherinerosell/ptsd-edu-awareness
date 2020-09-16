using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWordText : MonoBehaviour {

    private Text wordText;
    private InputHolderClass holderClass;
    private RectTransform PanelRect; // rectangular transform of the panel object

    private void Start() {
     
        PanelRect = GameObject.Find("CPSSPanel").GetComponent<RectTransform>();
        holderClass = new InputHolderClass();
        wordText = GetComponent<Text>();
        wordText.text = holderClass.getMainWord();
        wordText.transform.parent = PanelRect;
        wordText.transform.position = new Vector2(-328f, -181f);
    
    }


}
