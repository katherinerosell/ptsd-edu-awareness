using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    Rigidbody2D rb;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint11;
    public Transform spawnPoint22;
    public Transform spawnPoint33;
    public Transform spawnPoint44;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D c) {

        if (c.gameObject.name == "portal3") {
            rb.position = spawnPoint22.position;
        }
        if (c.gameObject.name == "portal1") {
            rb.position = spawnPoint44.position;
        }
        if (c.gameObject.name == "portal2") {
            rb.position = spawnPoint33.position;
        }
        if (c.gameObject.name == "portal4") {
            rb.position = spawnPoint11.position;
        }
        if (c.gameObject.name == "portal11") {
            rb.position = spawnPoint4.position;
        }
        if (c.gameObject.name == "portal22") {
            rb.position = spawnPoint3.position;
        }
        if (c.gameObject.name == "portal33") {
            rb.position = spawnPoint2.position;
        }
        if (c.gameObject.name == "portal44") {
            rb.position = spawnPoint1.position;
        }
    }

}
