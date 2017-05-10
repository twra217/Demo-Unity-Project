using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public float rotateSpeed = 1.0f;

    public Vector3 spinSpeed = new Vector3(0,0,0); //vector3.zero 
                                                   //public variables accessable in editor


    public Vector3 spinAxis = new Vector3(0, 1, 0);

	// Use this for initialization
	void Start () {
        //this.transform.position = new Vector3(0, 5, 0); //vector 3 means expecting 3 values
   //     setSize(2.0f);

        spinSpeed = new Vector3(Random.value, Random.value, Random.value);

        spinAxis = Vector3.up;
        spinAxis.x = (Random.value - Random.value) * .1f; //multiply means no bigger than 0.1
	}
	                        
    public void setSize (float size)    //void means it passes back nothing --> data return type goes there
    {
        this.transform.localScale = new Vector3(size,size,size);

    }

	// Update is called once per frame
	void Update () {
        this.transform.Rotate(spinSpeed); //'floating point requires f'
        //rotate --> around its own axis
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed); //rotate around centre, up direction, 1 degree/frame
        //rotate around origin, up shorthand for 0,1,0
    }
}
