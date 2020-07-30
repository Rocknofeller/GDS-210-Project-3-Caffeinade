using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeGunController : MonoBehaviour
{
	public Transform weaponHold;
	public CoffeeGun startingGun;
	CoffeeGun equippedGun;

	void Start()
	{
		if (startingGun != null)
		{
			EquipGun(startingGun);
		}
	}

	public void EquipGun(CoffeeGun gunToEquip)
	{
		if (equippedGun != null)
		{
			Destroy(equippedGun.gameObject);
		}
		equippedGun = Instantiate(gunToEquip, weaponHold.position, weaponHold.rotation) as CoffeeGun;
		equippedGun.transform.parent = weaponHold;
	}

	//public void Shoot()
	//{
	//	if (equippedGun != null)
	//	{
	//		equippedGun.Shoot();
	//	}
	//}
}
