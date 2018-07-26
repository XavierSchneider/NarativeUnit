using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAnimation : MonoBehaviour {

	public Animator animator;
	public float interactDelay = 0;

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {

			Invoke ("PlayAnimation", interactDelay);
		}
	}
	
	// Update is called once per frame
	private void PlayAnimation() 
	{
		animator.SetTrigger ("play");
	}
}
