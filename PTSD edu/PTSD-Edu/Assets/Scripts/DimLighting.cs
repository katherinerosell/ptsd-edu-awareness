using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLighting : MonoBehaviour {
    public GameObject shadowbox;
    private float myTimer;
    void Start() {
        myTimer = 0f;
        shadowbox.SetActive(false);
    }

    private void FixedUpdate() {
        myTimer += Time.deltaTime;
        if ((int)myTimer == 120) { //after 2 minutes of regular gameplay, display shadow box for limited visibility
            Debug.Log("Display Shadow Box");
            //SpriteRenderer rend = shadowbox.GetComponent<SpriteRenderer>();
            //LeanTween.color(shadowbox, new Color(0f, 0f, 0f), LeanTween.easeInSine(0f, 10f, 10f));
            shadowbox.SetActive(true);
        }
    }

}
