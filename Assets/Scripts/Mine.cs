using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{

	// Use this for initialization
	[SerializeField] private int _damage;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			var enemy = other.GetComponent<MyEnemy>();
			enemy.Hurt(_damage);
			Destroy(gameObject);
		}
	}

}