using UnityEngine;
using System.Collections;

public class cameracontroller : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    private Vector3 offset;

	void Start () {
        offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void lateupdate () {

        transform.position = player.transform.position + offset;

	}
}
