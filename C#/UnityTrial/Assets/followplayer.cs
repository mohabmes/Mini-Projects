using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {
    public GameObject player;
    public Vector3 separation_value = new Vector3(3, 0, 3);

    public float timetoreach = 2;
    private Vector3 currentVelocity = Vector3.zero;

    public int flag = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (flag >= 1)
        {
            Vector3 target = player.transform.position + separation_value;

            Vector3 newposition = Vector3.SmoothDamp(this.transform.position, target,
                ref currentVelocity, timetoreach);

            this.transform.position = newposition;
        }
        
	}
    public void changeFlag()
    {
        flag += 1;
    }
}
