using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl14PlayerCollision : MonoBehaviour {

    private SpriteRenderer sprite; // the player's sprite renderer
    private int hits; // on first, on second hit... color is different

    [SerializeField]
    Color medRed;
    [SerializeField]
    Color deepRed;
    [SerializeField]
    Color ogWhite;

    private void Start() {
        hits = 0;
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.tag == "enemy") {
            hits++;
            switch (hits) {
                case 1: 
                    sprite.color = medRed;
                    break;
                case 2:
                    sprite.color = deepRed;
                    break;
                default:
                    sprite.color = ogWhite;
                    break;
            }          
        }
        
    }



}
