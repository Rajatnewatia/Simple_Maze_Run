using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour {

	public Text coinsLeft;
	public int cur_coins = 0;
	public int max_coins = 0;

	public GameObject Door;

	// Use this for initialization
	void Start () {
		
		Door.SetActive (false);
		max_coins = cur_coins;
		UpdateUI ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void UpdateUI()
	{
		if (cur_coins > 0) 
		{
			coinsLeft.text = " Keys Left : " + cur_coins.ToString ("D2") + "/" + max_coins.ToString ("D2");  
		} 
		else if (cur_coins <= 0) 
		{
			Door.SetActive (true);
			coinsLeft.text = " Keys Left : " + cur_coins.ToString ("D2") + "/" + max_coins.ToString ("D2");  
		}
	 	}
}
