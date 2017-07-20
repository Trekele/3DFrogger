using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour {

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("test");
        if (other.tag == "frog")
        {
            other.SendMessage("hit");
        }
    }

}
