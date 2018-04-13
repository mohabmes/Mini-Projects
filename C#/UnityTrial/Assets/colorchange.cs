using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {
    public GameObject player;
    public int flag = 0;
    //public int distance_threshold = 500;
    private Color 
        near = Color.green,
        far = Color.red;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Color target;
        target = far;
        if (flag >= 2)
        {
            //float distance = Vector3.Distance(this.transform.position, player.transform.position);
            
            //if (distance < distance_threshold)
            //{
                
            //}
           // else
            //{
                
                target = near;
            //}
                changecolor(target);
        }
        
	}

    void changecolor(Color t)
    {
        Transform obj = this.transform;
        MeshRenderer render = obj.GetComponent<MeshRenderer>();

        Color current = render.material.color;
        render.material.color = Color.Lerp(current, t, 0.5f * Time.deltaTime);
    }

    public void changeFlag()
    {
        flag += 1;
    }
}
