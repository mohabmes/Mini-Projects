using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalechange : MonoBehaviour {
    public GameObject player;
    public float distance_threshold = 30;
    Vector3 temp;
    public int flag = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (flag >= 3)
        {
            temp = transform.localScale;
            float distance = Vector3.Distance(this.transform.position, player.transform.position);

            temp.y += 0.005f;
            temp.x += 0.005f;
            transform.localScale = temp;
        }
    }
    void changescale(float v)
    {
        temp.y = v;
        temp.x = v;
        transform.localScale = temp;

    }
    public void changeFlag()
    {
        flag += 1;
    }
}
