using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public int levelToLoad;
	public AudioClip next;

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Application.LoadLevel (levelToLoad);
			AudioManager.instance.PlaySound (next, transform.position);
		}
	}





}