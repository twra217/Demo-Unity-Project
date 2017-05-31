using UnityEngine;
using Pathfinding.Serialization.JsonFx; //make sure you include this using

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
    public string _WebsiteURL = "http://twra217.azurewebsites.net/tables/Product?zumo-api-version=2.0.0";
    public GameObject myPreFab;
    int totalCubes = 15;
    float totalDistance = 2.0f;

    void Start () {
        //Reguest.GET can be called passing in your ODATA url as a string in the form:
        //http://{Your Site Name}.azurewebsites.net/tables/{Your Table Name}?zumo-api-version=2.0.0
        //The response produce is a JSON string
        string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        //We can now deserialize into an array of objects - in this case the class we created. The deserializer is smart enough to instantiate all the classes and populate the variables based on column name.
        TreeSurvey[] treesurveys = JsonReader.Deserialize<TreeSurvey[]>(jsonResponse);

        //----------------------
        //YOU WILL NEED TO DECLARE SOME VARIABLES HERE SIMILAR TO THE CREATIVE CODING TUTORIAL
   
        //----------------------

        //We can now loop through the array of objects and access each object individually
        foreach (TreeSurvey treesurvey in treesurveys)
        {
            //Example of how to use the object
            Debug.Log("This products name is: " + treesurvey.Location);
            //----------------------
           

                

            //----------------------
        }
        for (int i= 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;
            float x = perc * totalDistance;
            float y = 5.0f;
            float z = 0f;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);

            newCube.GetComponent<CubeScript>().setSize(1.0f - perc);
            newCube.GetComponent<CubeScript>().rotateSpeed = 1.0f - perc;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
