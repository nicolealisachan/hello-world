using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

	public GameObject myPrefab; 

	// Use this for initialization
	void Start () {

		for ( int i = 0; i < 3; i++ )
		{ 
			float x = 3.0f; 
			float y = 5.0f; 
			float z = 0.0f; 

			var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity); 
			newCube.GetComponent<CubeScript>().SetSize(1.5f); 

	}



	
	// Update is called once per frame
	void Update () {
	
	}
}
