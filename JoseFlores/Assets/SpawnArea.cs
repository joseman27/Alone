using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour {

    public float speed;
    // Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKey (KeyCode.A)) {
            transform.Translate(new Vector3(-35, 0, 0) * Time.deltaTime);
       
		
	}
}
