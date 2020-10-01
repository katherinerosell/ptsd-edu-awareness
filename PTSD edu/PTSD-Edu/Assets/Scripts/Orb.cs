using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
    public GameObject _gm;
    private PortalOrbColor portalOrbColor;
    private GameObject tempObj;

    private void Start() {
        portalOrbColor = _gm.GetComponent<PortalOrbColor>();
        tempObj = portalOrbColor.getColorPortal();
    }

    private void OnCollisionEnter2D(Collision2D c) {
        Debug.Log("Game Object: " + c.gameObject.name);
        tempObj = portalOrbColor.getColorPortal();
        if (c.gameObject == tempObj) {
            portalOrbColor.CorrectPortalCollision();
        }
    }


}
