using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpCube : MonoBehaviour {

    public GameObject otherCube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "frog")
        {
            other.attachedRigidbody.MovePosition(new Vector3(otherCube.transform.position.x, otherCube.transform.position.y + 1, otherCube.transform.position.z));
        }

    }
}
