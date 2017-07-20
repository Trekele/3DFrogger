using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour {

    int x = 0;
    public bool up = true;
    private void FixedUpdate()
    {
        if(up)
        {
             this.transform.Translate(0, -.015f, 0);
              x++;
            if(x==150)
            {
                up = false;
                x = 0;
            }
        }
        else
        {
            this.transform.Translate(0, .015f, 0);
            x++;
            if (x == 150)
            {
                up = true;
                x = 0;
            }
        }
       
    }

}
