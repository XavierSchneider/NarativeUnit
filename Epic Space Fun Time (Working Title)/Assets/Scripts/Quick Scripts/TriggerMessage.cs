using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour {

	public string messageToShow = "Default plain ass message";
	public float messageDuration = 3;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			GameObject.FindObjectOfType<UIController> ().
			ShowMessage (messageToShow, messageDuration);
		}
	}
}
