using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShipController : MonoBehaviour
{

    //private Transform transformComponent;

    void Awake()
    {
        //transformComponent = GetComponent<Transform>();
    }

	void Start () {
		
	}
	
	void Update ()
	{
	    float x = Input.GetAxis("Horizontal");
	    float y = Input.GetAxis("Vertical");
        transform.Translate(0,y,0);
        transform.Rotate(0,0,-x);
    }
}
