using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirbabü : MonoBehaviour
{
    public float kirsayac;

	private void Update()
	{
		if (kirsayac == 4)
		{
			//18 saat sonra texti girecek
			Destroy(gameObject);
		}
	}
}
