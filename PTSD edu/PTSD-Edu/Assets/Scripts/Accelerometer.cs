using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

    private Rigidbody myRB;

	private void Start () {
        myRB = GetComponent<Rigidbody>();
	}

    private void Update()  {
        

        Vector3 tilt = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z); //front and back acceleration have to be flipped
        
            //tilt = Quaternion.Euler(0f, 0f, -90f) * tilt;
            
        myRB.AddForce(Input.acceleration.x, Input.acceleration.y, -(Input.acceleration.z) * 4);
     
           
        //Debug.DrawRay(transform.position + Vector3.up, tilt, Color.magenta);
    

        Debug.Log(Input.acceleration);
   
    }

}
