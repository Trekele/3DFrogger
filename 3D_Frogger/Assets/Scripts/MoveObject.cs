using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public enum Direction
    {
        Z,X,Y
    }

    public bool movePositive = true;
    public Direction direction = Direction.X;
    public double maxDistance = 1;

    private Vector3 startingPosition;
    // Use this for initialization
    void Start () {
        startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        switch (direction)
        {
            case Direction.Z:
                if (movePositive)
                {
                    transform.Translate(0, 0, 1 * Time.deltaTime);
                    if (transform.position.z >= startingPosition.z + maxDistance)
                    {
                        movePositive = false;
                    }
                }
                else
                {
                    transform.Translate(0, 0, -1 * Time.deltaTime);
                    if (transform.position.z <= startingPosition.z)
                    {
                        movePositive = true;
                    }
                }
                break;
            case Direction.X:
                if (movePositive)
                {
                    transform.Translate(1 * Time.deltaTime, 0, 0);
                    if (transform.position.x >= startingPosition.x + maxDistance)
                    {
                        movePositive = false;
                    }
                }
                else
                {
                    transform.Translate(-1 * Time.deltaTime, 0,0);
                    if (transform.position.x <= startingPosition.x)
                    {
                        movePositive = true;
                    }
                }
                break;
            case Direction.Y:
                if (movePositive)
                {
                    transform.Translate(0, 1 * Time.deltaTime, 0);
                    if (transform.position.y >= startingPosition.y + maxDistance)
                    {
                        movePositive = false;
                    }
                }
                else
                {
                    transform.Translate(0, -1 * Time.deltaTime, 0);
                    if (transform.position.y <= startingPosition.y)
                    {
                        movePositive = true;
                    }
                }
                break;
            default:
                break;
        }
    }
}
