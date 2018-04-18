using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivingEntityplayer : MonoBehaviour, IDamageable {

	public float startingHealth;
	protected float health;
	protected bool dead;
	public int levelToLoad;
	public Slider healthbar;
	public AudioClip attackaudio;



	public event System.Action OnDeath;

	protected virtual void Start() {
		health = startingHealth;
	}

	public virtual void TakeHit(float damage, Vector3 hitPoint, Vector3 hitDirection) {
		// Do some stuff here with hit var
		TakeDamage (damage);
	}

	public virtual void TakeDamage(float damage) {
		health -= damage;
		healthbar.value = health
		AudioManager.instance.PlaySound (attackaudio, transform.position);

		if (health <= 0 && !dead) {
			Die();
		}
	}

	[ContextMenu("Self Destruct")]
	protected void Die() {
		dead = true;
		if (OnDeath != null) {
			OnDeath();
		}
		GameObject.Destroy (gameObject);
		Application.LoadLevel (levelToLoad);
	}
}






