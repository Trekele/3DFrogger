using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour {

    int x = 0;
    public bool left = true;
    private void FixedUpdate()
    {
        if (left)
        {
            this.transform.Translate(-.10f, 0, 0);
            x++;
            if (x == 50)
            {
                left = false;
                x = 0;
            }
        }
        else
        {
            this.transform.Translate(.10f,0, 0);
            x++;
            if (x == 50)
            {
                left = true;
                x = 0;
            }
        }

    }
}
