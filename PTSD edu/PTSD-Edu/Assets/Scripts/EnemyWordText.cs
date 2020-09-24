using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWordText : MonoBehaviour {

    public Text wordText;
    private InputHolderClass holderClass;
    private Camera sceneCam;
    private Canvas wtCanvas;

    private void Awake() {
        holderClass = GameObject.Find("_GM").GetComponent<InputHolderClass>(); // _GM object has the script attached
        wordText.text = holderClass.getMainWord();
    }

    private void Start() {
        wordText.text = holderClass.getMainWord();
        sceneCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        wtCanvas = GameObject.Find("WTCanvas").GetComponent<Canvas>();
        wtCanvas.renderMode = RenderMode.WorldSpace;
        wtCanvas.worldCamera = sceneCam;        
    }

    private void OnTriggerEnter2D(Collider2D c) {
        //Debug.Log(c.gameObject.name.ToString());

        if (c.gameObject.tag == "Enemy") {
            //Debug.Log("e n e m y - ignore collision");
        }

        if (c.gameObject.tag == "KillWall")
        {
            //Debug.Log("self destruct");
            Destroy(gameObject);
        }

        if (c.gameObject.tag == "Player")
        {
            //decrease 'health' points
            //Debug.Log("player collision!!!");
            Destroy(gameObject);
        }

    }


}
