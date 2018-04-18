using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

	CoinManagerScript GMS;
	public float rotateSpeed = 100f;
	public AudioClip coinmila;

	// Use this for initialization
	void Awake()
	{
		GMS = GameObject.Find ("CoinManager").GetComponent<CoinManagerScript> ();
		GMS.cur_coins++;

	}
	void Start () {

		//GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
		//GMS.cur_coins++;

	}

	// Update is called once per frame
	void Update () {

		transform.Rotate(rotateSpeed ,rotateSpeed ,0);

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Destroy (gameObject);
			GMS.cur_coins--;
			GMS.coll_coins++;

			GMS.UpdateUI ();
			AudioManager.instance.PlaySound (coinmila, transform.position);

		}
	}

}