using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunController : MonoBehaviour {

	public Transform weaponHold;
	public Gun startingGun;
	Gun equippedGun;
	public float timy = 20;
	public Slider timerbar;


	void Start() {
		if (startingGun != null) {
			EquipGun(startingGun);
		}
	}

	public void Update()
	{
		timy -= Time.deltaTime;
		timerbar.value = timy;
	}


	public void EquipGun(Gun gunToEquip) {
		if (equippedGun != null) {
			Destroy(equippedGun.gameObject);
		}
		equippedGun = Instantiate (gunToEquip, weaponHold.position,weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;
	}

	public void Shoot() {
		if(timy > 0 ){
		if (equippedGun != null) {
			equippedGun.Shoot();
		}
	}
}
}