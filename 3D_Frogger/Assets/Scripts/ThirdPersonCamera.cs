using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
                
	}	
	
	void Update () {
        this.gameObject.transform.position = new Vector3(player.transform.position.x, .5f, player.transform.position.z-2);
    }
}
