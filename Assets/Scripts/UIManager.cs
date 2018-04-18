using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public int levelToLoad;
	public GameObject Hscore;
	public GameObject Rules;
	void Start () {

		Hscore.SetActive (false);
		Rules.SetActive (false);
	}
	public void play()

		
		{
			Application.LoadLevel (levelToLoad);
		}
	public void activateUI()
	{
		{
			Hscore.SetActive (true);
		}
	}
	public void deactivateUI()
	{
		{
			Hscore.SetActive (false);
		}
	}
	public void activaterulesUI()
	{
		{
			Rules.SetActive (true);
		}
	}
	public void deactivaterulesUI()
	{
		{
			Rules.SetActive (false);
		}
	}




}
