using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmbrellaScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D c) { // since WordText uses isTrigger too
        if (c.gameObject.tag == "Enemy") Destroy(c.gameObject);
    }

}
