using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPreFab;



	// Use this for initialization
	void Start () {

        int totalCubes = 12;

        int totalDistance = 5;

        for(int i =0; i< (float)totalCubes; i++) //have to cast at least one as floating point to get fractio
        {

            float perc = i / totalCubes;

            float x = perc * totalDistance;
            float y = 5.0f;
            float z = 0.0f;
            //cast as game object
            var newCube = (GameObject)Instantiate(myPreFab, new Vector3(3, 5, 0), Quaternion.identity); //what to instantiate, orientation
                                                                                                        //instantiate prefab
            newCube.GetComponent<CubeScript>().setSize(1.0f - perc); //reach into prefab
            newCube.GetComponent<CubeScript>().rotateSpeed = 1.0f - perc; //Random.value;
        }

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
