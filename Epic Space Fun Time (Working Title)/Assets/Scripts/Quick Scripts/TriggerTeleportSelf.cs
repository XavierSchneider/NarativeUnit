using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleportSelf : MonoBehaviour {

	public Transform transformToTeleportObjectTo;

	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player")
		{
			if (other.tag == "Player")
			{
				Debug.LogWarning ("Ya dia'nt assign a reference point for tha TP, ya shit");
			}

			other.transform.position = transformToTeleportObjectTo.position;
			other.transform.position = transformToTeleportObjectTo.position;
		}
	}

	void OnDrawGizmosSelected()
	{
		if(transformToTeleportObjectTo) {
			Debug.DrawLine (transform.position, transformToTeleportObjectTo.transform.position);
		}
	}
}
				
