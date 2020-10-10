using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * This script is attached to the prefab, WordText.
 * It handles the general setup of the object, using the
 * _GM, or game manager
 * Author: Katherine Rosell
 * Date: August 2020
 * */

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


}
