using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Yo");
        }
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Bye bitch");
        }
	}

    //when you stay
    void OnTriggerStay (Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("ummm can you like, leave?");
        }
    }
}
