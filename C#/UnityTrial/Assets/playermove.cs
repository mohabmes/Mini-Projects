using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

    public int forwardspeed = 5;
    public int rotationspeed = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(transform.forward * forwardspeed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(- transform.forward * forwardspeed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 angleVector = new Vector3(0, rotationspeed, 0) * Time.deltaTime;
            this.transform.Rotate(angleVector);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 angleVector = new Vector3(0, - rotationspeed, 0) * Time.deltaTime;
            this.transform.Rotate(angleVector);
        }
	}
}
