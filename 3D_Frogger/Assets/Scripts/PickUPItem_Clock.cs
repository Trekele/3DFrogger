using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPItem_Clock : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "frog")
        {
            Score.time += 10f;
            Destroy(this.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Rotate(0, 1f, 0);
    }
}
