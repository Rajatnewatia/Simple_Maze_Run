using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	public float timer = 90;

	void Start() {
		AudioManager.instance.PlayMusic (mainTheme , 2 );
        }

	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
			
	       AudioManager.instance.PlayMusic (mainTheme, 2);
		   timer = 90;
		}


	}
}
