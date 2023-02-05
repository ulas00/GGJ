using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirbabü : MonoBehaviour
{
    public float kirsayac;
	public esbergorev esbo;
	private void Update()
	{
		if (kirsayac == 4)
		{
            //18 saat sonra texti girecek
            esbo.gorev1yapildi = true;
			esbo.esbergorev2.SetActive(true);
            Destroy(gameObject);
		}
	}
}
