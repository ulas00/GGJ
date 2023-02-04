using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerSpawner : MonoBehaviour
{
	public GameObject[] tigerSpawns;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("player"))
		{
			for (int i = 0; i < tigerSpawns.Length; i++)
			{
				tigerSpawns[i].SetActive(true);
			}
		}
	}
}
