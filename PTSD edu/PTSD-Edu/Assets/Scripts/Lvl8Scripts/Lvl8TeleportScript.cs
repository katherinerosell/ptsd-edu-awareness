using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8TeleportScript : MonoBehaviour {

    Rigidbody2D rb;
    readonly float voosh = 10f;

    public Transform sp1;
    public Transform sp2;
    public Transform sp3;
    public Transform sp4;
    public Transform sp5;
    public Transform sp6;
    public Transform sp7;
    public Transform sp8;
    public Transform sp9;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D c) {

        if (c.gameObject.name == "portal1") {
            rb.position = sp4.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal2") {
            rb.position = sp8.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal3") {
            rb.position = sp5.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal4") {
            rb.position = sp3.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal5") {
            rb.position = sp1.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal6") {
            rb.position = sp2.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal7") {
            rb.position = sp9.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal8") {
            rb.position = sp6.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }
        if (c.gameObject.name == "portal9") {
            rb.position = sp7.position;
            rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);
        }


    }

}
