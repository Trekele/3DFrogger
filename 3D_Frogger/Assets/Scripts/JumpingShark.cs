using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingShark : MonoBehaviour {

    private Vector3 initialTransform;
    private Quaternion initialRotation;

    // Use this for initialization
    void Start () {
        
        initialTransform = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        initialRotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
        StartCoroutine("JumpOutOfWater");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator JumpOutOfWater()
    {
        float random = Random.Range(0, 10);
         yield return new WaitForSeconds(random);
        while (true)
        {
            while (gameObject.transform.position.y < 0)
            {
                transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .1f, gameObject.transform.position.z);
                yield return null;
            }

            while (gameObject.transform.position.z < initialTransform.z + 2)
            {
                transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + .2f);
                transform.Rotate(18, 0, 0);
                yield return null;
            }

            while (gameObject.transform.position.y > -4)
            {
                transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - .1f, gameObject.transform.position.z);
                yield return null;
            }

            transform.position = initialTransform;
            transform.rotation = initialRotation;
            yield return new WaitForSeconds(.5f);
        }
    }

    private IEnumerable Wait(int milisec)
    {
        yield return new WaitForSeconds(milisec/1000);
    }
}
