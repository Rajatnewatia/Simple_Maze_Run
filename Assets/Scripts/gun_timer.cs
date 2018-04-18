using UnityEngine;
using System.Collections;

public class gun_timer : MonoBehaviour {

	GunController GMS;
	public float rotateSpeed = 100f;
	public float recharge = 5f;
	public AudioClip boostAudio;


	// Use this for initialization
	void Awake()
	{
		GMS = GameObject.Find ("Player").GetComponent<GunController> ();


	}
	void Start () {

		//GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
		//GMS.cur_coins++;

	}

	// Update is called once per frame
	void Update () {

		transform.Rotate(rotateSpeed ,rotateSpeed , 0);

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Destroy (gameObject);
			GMS.timy = recharge ;
			AudioManager.instance.PlaySound (boostAudio, transform.position);

		}
	}

}