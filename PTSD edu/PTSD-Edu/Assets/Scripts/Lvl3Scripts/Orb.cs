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

        if (c.gameObject.tag != "Player") //statement catches a NullReferenceException Error
        {
            if (c.gameObject == portalOrbColor.getColorPortal())
            {
                portalOrbColor.CorrectPortalCollision();
                // Debug.Log("Orb -- Collision(Collision2D) -- Correct Collision : " + c.gameObject.name);
            }
        }
    }


}
