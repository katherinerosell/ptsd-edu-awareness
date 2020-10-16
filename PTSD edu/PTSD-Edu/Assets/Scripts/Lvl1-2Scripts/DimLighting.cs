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
        if ((int)myTimer == 103) { //after 2 minutes of regular gameplay, display shadow box for limited visibility
            Debug.Log("Display Shadow Box");
            shadowbox.SetActive(true);
        }
    }

}
