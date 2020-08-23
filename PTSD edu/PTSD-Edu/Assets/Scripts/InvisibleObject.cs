using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Invisible Object
 * this script, when attached to any object, sets its
 * visibility to 'false.' Basically for debugging purposes
 * this script makes objects invisible but still able to 
 * exist in the game. 
 * @Author: Katherine Rosell
 * @Date: 7/10/2020
 * */
public class InvisibleObject : MonoBehaviour { 
    //get and set the sprite renderer to false to disable its visibility
    void Start() {
        SpriteRenderer rend = gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = false;
    }

}
