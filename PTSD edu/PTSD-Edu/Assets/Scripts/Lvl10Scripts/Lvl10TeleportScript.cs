using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl10TeleportScript : MonoBehaviour {

    Rigidbody2D rb;
    readonly float voosh = 3f;

    public Transform sp1;
    public Transform sp2;
    public Transform sp3;
    public Transform sp4;
    public Transform sp5;
    public Transform sp6;
    public Transform sp7;
    public Transform sp8;
    public Transform sp9;
    public Transform sp10;
    public Transform sp11;
    public Transform sp12;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D c) {

        switch (c.gameObject.name) {
            case "portal1":
                rb.position = sp6.position;
                break;
            case "portal2":
                rb.position = sp5.position;
                break;
            case "portal3":
                rb.position = sp7.position;
                break;
            case "portal4":
                rb.position = sp10.position;
                break;
            case "portal5":
                rb.position = sp2.position;
                break;
            case "portal6":
                rb.position = sp1.position;
                break;
            case "portal7":
                rb.position = sp3.position;
                break;
            case "portal8":
                rb.position = sp12.position;
                break;
            case "portal9":
                rb.position = sp11.position;
                break;
            case "portal10":
                rb.position = sp4.position;
                break;
            case "portal11":
                rb.position = sp9.position;
                break;
            case "portal12":
                rb.position = sp8.position;
                break;
        }
        
        if(gameObject.tag != "Player") rb.AddForce(transform.right * voosh, ForceMode2D.Impulse);


    }

}
