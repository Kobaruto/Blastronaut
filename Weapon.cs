using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public Transform FirePoint;
	public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Shoot"))
		{
			Shoot();
		}
    }

	void Shoot()
	{
		Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);


	}


}
