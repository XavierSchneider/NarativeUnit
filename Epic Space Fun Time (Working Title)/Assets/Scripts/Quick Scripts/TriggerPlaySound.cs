using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaySound : MonoBehaviour {

	public AudioClip clip;
	public float interactDelay = 0;

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player")
		{
			Invoke ("PlaySound", interactDelay);
		}
	}
	
	// Update is called once per frame
	private void PlaySound() 
	{
		AudioSource.PlayClipAtPoint (clip, transform.position);
	}
}
