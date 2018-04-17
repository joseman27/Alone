using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
        Debug.Log("Entre en Trigger con " + other);
        if (other.CompareTag("Player")) {
            other.GetComponent<ControldelJugador>().ResetPosition();
        }
		
	}
	
}
