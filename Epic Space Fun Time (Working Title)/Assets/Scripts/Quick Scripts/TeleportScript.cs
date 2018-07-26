using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

    public GameObject teleportNode;

	// Something Enters Trigger
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(0, 0, 0);
            {
                Vector3 nodeLocation = teleportNode.transform.position;
                other.transform.position = nodeLocation;
                Quaternion nodeRotation = teleportNode.transform.rotation;
                other.transform.rotation = nodeRotation;
            }
        }
	}
	
	// Update is called once per frame
	void OnDrawGizmos()
    {
		if (teleportNode) {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, teleportNode.transform.position);
        }
	}
}
