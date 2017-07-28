using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(30, 45, 45) * Time.deltaTime);
	
	}
}
