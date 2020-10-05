using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private int portalNum = 0; 

    private int correctPortals;

    [SerializeField]
    private Color newColor = new Color(80f, 20, 122f);

    private void Start() {
        correctPortals = 0;
        orbRender = orb.GetComponent<SpriteRenderer>();
        // initialize the size of an array to avoid "Index out of bounds exception"
        portals = new GameObject[8] { portal1, portal2, portal3, portal4, portal11, portal22, portal33, portal44 };
        ChangeColor();
    }

    public void ChangeColor() {
        int randomN = Random.Range(0, 8);
        Debug.Log("PortalOrbColor -- Random Num -- ChangeColor: " + randomN);
        portalNum = randomN;
        orbRender.color = newColor;
        spriteRenderer = portals[portalNum].GetComponent<SpriteRenderer>();
        spriteRenderer.color = newColor;
        Debug.Log("PortalOrbColor -- Portal Num -- ChangeColor: " + portalNum);
    }

    public GameObject getColorPortal() {
        //return portals[portalNum];
        return null;
    }

    public void CorrectPortalCollision() {
        correctPortals++;
        Debug.Log("PortalOrbColor -- CorrectPortalCollision -- Correct Portals: " + correctPortals);
    }


}
