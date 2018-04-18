using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CoinManagerScript : MonoBehaviour {

	public Text coinsLeft;
	public Text highscore;
	public int cur_coins = 0;
	public int max_coins = 0;
	public int coll_coins = 0;
	public static int mega = 0;




	//public GameObject Door;

	// Use this for initialization
	void Start () {


		highscore.text = PlayerPrefs.GetInt ("highscore",0).ToString ("D4");
		//Door.SetActive (false);

		max_coins = cur_coins;
	    UpdateUI ();
	}

	// Update is called once per frame
	void Update () {

   }
	public void UpdateUI()
	{
		//if (cur_coins > 0) 

		//{
		  mega = mega + coll_coins;
	      coinsLeft.text = " Score : " + mega.ToString ("D4") ;  
		//} 
		//else if (cur_coins <= 0) 
		//{
		if (mega > PlayerPrefs.GetInt ("highscore", 0)) 
		{
			PlayerPrefs.SetInt ("highscore", mega);
			highscore.text =  " HighScore : " + mega.ToString ("D4") ;  
		}
			//Door.SetActive (true);
			//coinsLeft.text = " Score : " + coll_coins.ToString ("D2") + "/" + max_coins.ToString ("D2");  
		//}
	}
}
