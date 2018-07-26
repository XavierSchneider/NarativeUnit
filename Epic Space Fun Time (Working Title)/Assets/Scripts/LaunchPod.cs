using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPod : MonoBehaviour {

    public GameObject escapePod;

    // Use this for initialization

    private void OnTriggerEnter(Collider other)
    {
        escapePod.GetComponent<Rigidbody>().useGravity = true;
    }

}
