using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lvl10DestoryWords : MonoBehaviour {

    public GameObject wordSpawner;
    public Button destroyButton;
    private ColorBlock buttonColors;
    private Image buttonImg;
    private float coolDown; 

    private void Start() {
        coolDown = 15f;
        buttonColors = destroyButton.colors;
        buttonImg = destroyButton.image;
    }

    public void DestroyWordsButton() {
        destroyButton.interactable = false; buttonImg.color = buttonColors.disabledColor;
        Rigidbody2D[] ChildrenObjs = wordSpawner.GetComponentsInChildren<Rigidbody2D>();
        foreach (Rigidbody2D rb in ChildrenObjs) {
            GameObject wordObj = rb.gameObject;
            Destroy(wordObj);
        }
        coolDown = Random.Range(8f, 15f);
        Invoke("CoolDownFunc", coolDown);
    }

    public void CoolDownFunc() {
        destroyButton.interactable = true; buttonImg.color = buttonColors.normalColor;
    }



}
