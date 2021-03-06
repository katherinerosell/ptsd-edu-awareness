﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalOrbColor : MonoBehaviour {

    public GameObject portal1;
    public GameObject portal2;
    public GameObject portal3;
    public GameObject portal4;
    public GameObject portal11;
    public GameObject portal22;
    public GameObject portal33;
    public GameObject portal44;

    public GameObject orb;
    private SpriteRenderer orbRender;

    private SpriteRenderer spriteRenderer;
    public GameObject[] portals;
    private int portalNum = 2; 
    private int correctPortals;
    private Scene _scene;

    [SerializeField]
    private Color newColor = new Color(80f, 20, 122f);
    public Color defaultColor;

    private void Awake() {
        // initialize the size of an array to avoid "Index out of bounds exception"  
        portals = new GameObject[8] { portal1, portal2, portal3, portal4, portal11, portal22, portal33, portal44 };
    }

    private void Start() {
        _scene = SceneManager.GetActiveScene();
        correctPortals = 0;
        orbRender = orb.GetComponent<SpriteRenderer>();           
        orbRender.color = newColor;
        ChangeColor();
        newColor.a = 1.0f;
        defaultColor.a = 1.0f;
    }

    private void Update() {

        if (_scene.name == "Level3" && correctPortals == 5 ) {
            // done with level 3, go to level 4
            SceneManager.LoadScene("Level4");
        }
        if (_scene.name == "Level10" && correctPortals == 5) {
            // done with level 10, go to level 14
            Debug.Log("9 portal collisions, go to Level14");
        }

    }

    public void ChangeColor() {
        int randomN = Random.Range(0, 8);
        // Debug.Log("PortalOrbColor -- Random Num -- ChangeColor: " + randomN);
        portalNum = randomN;
        spriteRenderer = portals[portalNum].GetComponent<SpriteRenderer>();
        spriteRenderer.color = newColor;
        // Debug.Log("PortalOrbColor -- Portal Num -- ChangeColor: " + portalNum);
    }

    public GameObject getColorPortal() {
        // return portals[portalNum];
        // Debug.Log("Portals Index: " + portalNum);
        // Debug.Log("Portal Name: " + portals[portalNum]);
        return portals[portalNum];
    }

    public void CorrectPortalCollision() {
        correctPortals++;
        // set the previous portal to the regular default color
        spriteRenderer = portals[portalNum].GetComponent<SpriteRenderer>();
        spriteRenderer.color = defaultColor;
        defaultColor.a = 1.0f;
        Debug.Log("Correct Portals: " + correctPortals);
        ChangeColor();
    }


}
