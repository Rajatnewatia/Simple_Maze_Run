using UnityEngine;
using System.Collections;

public class CoinBehaviour : MonoBehaviour {
	
	GameManagerScript GMS;
	public float rotateSpeed = 100f;
	public AudioClip keymilli;

	// Use this for initialization
	void Awake()
	{
		GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();
		GMS.cur_coins++;

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
			GMS.cur_coins--;
			AudioManager.instance.PlaySound (keymilli, transform.position);

			GMS.UpdateUI ();

		}
	}

}