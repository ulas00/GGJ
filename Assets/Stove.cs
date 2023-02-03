using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public GameObject spawnObj;
	public Transform spawnTransform;
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.gameObject.name);
		if (collision.gameObject.CompareTag("Cow"))
		{
			Destroy(collision.gameObject);
			Instantiate(spawnObj, spawnTransform);
		}
	}

}
