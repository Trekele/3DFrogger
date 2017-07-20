using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject car;
    public float delay = 1f;
    public float speed = 1f;

	// Use this for initialization
	void Start () {
              
        InvokeRepeating("SpawnCar", 0f, delay);
	}
	
	void SpawnCar()
    {    
        GameObject CAR = (GameObject)Instantiate(car, transform.position,transform.rotation);
        CAR.GetComponent<car>().speed = speed;
        Destroy(CAR, 12f);
    }
}
