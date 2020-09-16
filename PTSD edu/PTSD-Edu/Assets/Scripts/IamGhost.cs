using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IamGhost : MonoBehaviour {

    //private Text wordText;
    //private InputHolderClass holderClass;
    //private RectTransform PanelRect; // rectangular transform of the panel object

    private void Start() {
        /**
        PanelRect = GameObject.Find("CPSSPanel").GetComponent<RectTransform>();
        holderClass = new InputHolderClass();
        wordText = GetComponent<Text>();
        wordText.text = holderClass.getMainWord();
        wordText.transform.parent = PanelRect;
        wordText.transform.position = new Vector2(-328f, -181f);
    **/
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (c.gameObject.tag == "Enemy") {
            //Debug.Log("e n e m y - ignore collision");
        }

        if (c.gameObject.tag == "KillWall") {
            //Debug.Log("self destruct");
            Destroy(gameObject);
        }

        if (c.gameObject.tag == "Player") {
            //decrease 'health' points
            //Debug.Log("player collision!!!");
            Destroy(gameObject);
        }
    }

}
