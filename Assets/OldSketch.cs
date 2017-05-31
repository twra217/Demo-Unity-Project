//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Sketch : MonoBehaviour {

//    public GameObject myPreFab;



//	// Use this for initialization
//	void Start () {

//        int totalCubes = 15;

//        float totalDistance = 2.9f;

//        //Linear distribution
//        //for(int i =0; i< totalCubes; i++) //have to cast at least one as floating point to get fractio
//        //{

//        //    float perc = i / (float) totalCubes;

//        //    float x = perc * totalDistance;
//        //    float y = 5.0f;
//        //    float z = 0.0f;
//        //    //cast as game object
//        //    var newCube = (GameObject)Instantiate(myPreFab, new Vector3(x, y, z), Quaternion.identity); //what to instantiate, orientation
//        //                                                                                                //instantiate prefab
//        //    newCube.GetComponent<CubeScript>().setSize(1.0f - perc); //reach into prefab
//        //    newCube.GetComponent<CubeScript>().rotateSpeed = 1.0f - perc; //Random.value;
//        //}

//        //Sin distribution
//        for (int i = 0; i < totalCubes; i++) //have to cast at least one as floating point to get fractio
//        {

//            float perc = i / (float)totalCubes;

//            float sin = Mathf.Sin(perc * Mathf.PI/2);

//            float x = 1.8f + sin   * totalDistance;
//            float y = 6.0f;
//            float z = 0.0f;
//            //cast as game object
//            var newCube = (GameObject)Instantiate(myPreFab, new Vector3(x, y, z), Quaternion.identity); //what to instantiate, orientation
//                                                                                                        //instantiate prefab
//            newCube.GetComponent<CubeScript>().setSize(.35f*(1.0f - perc)); //reach into prefab
//            newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f; //Random.value;
//        }

//    }
	
//	// Update is called once per frame
//	void Update () {
		
//	}
//}
