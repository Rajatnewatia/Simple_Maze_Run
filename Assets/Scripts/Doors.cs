using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	Animator animator;
	bool Dooropen;

	void Start()
	{
		Dooropen = false;
		animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player"){
			Dooropen = true;
			DoorControl ("Open");
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(Dooropen){
			Dooropen = false;
			DoorControl("Close");
		}
	}
	void DoorControl(string direction)
	{
		animator.SetTrigger (direction);
	}
}