using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 3f;
	
	void Start () {

       // speed = Random.Range(2f, 8f);

	}
	
	
	void FixedUpdate () {

        Vector3 forward = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

        if (transform.position.x > 10)
        {
            Destroy(this.gameObject);
        }

    }

}
