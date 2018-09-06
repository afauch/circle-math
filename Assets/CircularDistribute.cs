using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularDistribute : MonoBehaviour {

	public GameObject _objectToDistribute;
	public int _numberOfObjects;
	public float _circleRadius;
	public Vector3 _origin = new Vector3 (0.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {

		DistributeInCircle (_numberOfObjects, _circleRadius);

	}
	
	// Update is called once per frame
	void Update () {



	}


	void DistributeInCircle(int numberOfObjects, float circleRadius) {

		// TODO: Assumption is that you want the distribution on the X/Z plane

		// TODO: Assumption is that first object starts at (0, circleRadius)

		// Calculate the angular separation based on the number of objects

		// float angularDistance = 360.0f / numberOfObjects;


		for (int i = 0; i < numberOfObjects; i++) {

			float angle = i * (Mathf.PI * 2.0f) / numberOfObjects;
			Vector3 newPos = new Vector3 (Mathf.Cos (angle) * circleRadius, _origin.y, Mathf.Sin (angle) * circleRadius);

			GameObject g = (GameObject)GameObject.Instantiate (_objectToDistribute, newPos, Quaternion.identity);

			g.name = i.ToString();
			g.transform.LookAt (_origin);
		}

	}

}
