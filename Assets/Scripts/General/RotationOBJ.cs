using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOBJ : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    public int rotateSpeed = 1;

	void Update () {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
	}
}
